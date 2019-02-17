using SharepointHelper.DataBaseLayer;
using SharepointHelper.Helpers;
using System;
using System.Net.Mail;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using Microsoft.SharePoint.Client;
using System.Security;
using System.Data;

namespace SharepointHelper.Pages
{
    /// <summary>
    /// Interaction logic for ManageEDF.xaml
    /// </summary>
    public partial class ManageEDF : UserControl
    {
        #region Properties
        private Main wndMain;

        #endregion

        #region Constructors
        public ManageEDF()
        {
            InitializeComponent();
        }

        #endregion

        #region Events
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            wndMain = (Main)Window.GetWindow(this);
            LoadData();
        }
        #endregion

        #region Methodts
        public void LoadData()
        {

        }


        #endregion

        #region NotificationLoad

        private Thread LoadThread;
        private string ErrorMessage;

        private void StartLoad()
        {
            LoadThread = wndMain.StartLoad();
        }
        private void StopLoad()
        {
            wndMain.StopLoad(LoadThread);
        }
        private void SetMessageInfo(string message, MessageType msgType)
        {
            switch (msgType)
            {
                case MessageType.Success:
                    MessageBox.Show(message, "Success!!!", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                case MessageType.Error:
                    MessageBox.Show(message + ErrorMessage, "Error!!!", MessageBoxButton.OK, MessageBoxImage.Error);
                    break;
                default:
                    MessageBox.Show(message, "Info!!!", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
            }
            ErrorMessage = string.Empty;
        }

        #endregion NotificationLoad

        private void btnInsertAppRequest_Click(object sender, RoutedEventArgs e)
        {
            StartLoad();
            string autorId = appReqAutorId.Text.Trim();
            string requestId = appReqId.Text.Trim();
            string state = appReqState.Text.Replace("True", "1").Replace("False", "0");
            string addDate = (string.IsNullOrEmpty(appReqAddDate.Text)) ? DateTime.Now.ToLongDateString() : Convert.ToDateTime(appReqAddDate.Text).ToString("yyyy-MM-dd");
            string approveDate = (string.IsNullOrEmpty(appReqApproveDate.Text)) ? "" : Convert.ToDateTime(appReqApproveDate.Text).ToString("yyyy-MM-dd");
            string replaceId = appReqRepId.Text.Trim();
            string status = appReqStatus.Text.Trim();

            appReqAutorId.Text = string.Empty;
            appReqId.Text = string.Empty;
            appReqAddDate.Text = string.Empty;
            appReqApproveDate.Text = string.Empty;
            appReqRepId.Text = string.Empty;
            appReqStatus.Text = string.Empty;

            StopLoad();
            if (ManageEdfDAO.InsertAppReq(autorId, requestId, state, addDate, approveDate, replaceId, status))
                SetMessageInfo("Row successfully inserted!", MessageType.Success);
        }

        private void btnInsertNotification_Click(object sender, RoutedEventArgs e)
        {
            StartLoad();
            string userId = notificationAutorId.Text.Trim();
            string dateAdd = (string.IsNullOrEmpty(notificationAddDate.Text)) ? DateTime.Now.ToLongDateString() : Convert.ToDateTime(notificationAddDate.Text).ToString("yyyy-MM-dd");
            string visited = notificationVisited.Text.Replace("True", "1").Replace("False", "0");
            string visitUrl = notificationVisitUrl.Text.Trim();
            string message = notificationMessage.Text.Trim();
            string avatar = notificationAvatar.Text.Trim();
            string typeId = (notificationTypeId.SelectedIndex + 1).ToString();

            //notificationAutorId.Text = string.Empty;
            //notificationAddDate.Text = string.Empty;
            //notificationVisitUrl.Text = string.Empty;
            //notificationMessage.Text = string.Empty;
            //notificationAvatar.Text = string.Empty;
            StopLoad();
            if (ManageEdfDAO.InsertNotification(userId, dateAdd, visited, visitUrl, message, avatar, typeId))
                SetMessageInfo("Row successfully inserted!", MessageType.Success);
        }
        private void btnSendEmail_Click(object sender, RoutedEventArgs e)
        {
            string subject = "EDF - Notification";

            string body = notificationMessage.Text.Trim() + "<p>URL: <a href='" + notificationVisitUrl.Text.Trim() + "'>" + notificationVisitUrl.Text.Trim() + "</a></p>";

            string mail = notificationEmail.Text.Trim();

            SendMail(subject, mail, body);
        }
        public void SendMail(string subject, string To, string msg)
        {
            try
            {
                StartLoad();
                string host = Constants.EmailHost;

                string fromEmail = Constants.EmailFrom;

                SmtpClient mySmtpClient = new SmtpClient(host);

                MailAddress from = new MailAddress(fromEmail, fromEmail);
                MailAddress to = new MailAddress(To, To);
                MailMessage myMail = new System.Net.Mail.MailMessage(from, to);

                myMail.Subject = string.Format(subject);
                myMail.SubjectEncoding = System.Text.Encoding.UTF8;

                myMail.Body = msg;
                myMail.BodyEncoding = System.Text.Encoding.UTF8;
                // text or html
                myMail.IsBodyHtml = true;

                mySmtpClient.Send(myMail);
                StopLoad();
                SetMessageInfo("Email successfully send! ", MessageType.Success);
            }
            catch (Exception ex)
            {
                StopLoad();
                SetMessageInfo(ex.Message, MessageType.Error);
            }
        }

        private void btnInsertRequest_Click(object sender, RoutedEventArgs e)
        {
            StartLoad();
            string typeId = (reqTypeId.SelectedIndex + 1).ToString();
            string autorId = reqAutorId.Text.Trim();
            string addDate = Convert.ToDateTime(reqAddDate.Text).ToString("yyyy-MM-dd");
            string state = reqState.Text.Replace("True", "1").Replace("False", "0");

            reqAutorId.Text = string.Empty;
            reqAddDate.Text = string.Empty;
            StopLoad();
            if (ManageEdfDAO.InsertRequest(typeId, autorId, addDate, state))
                SetMessageInfo("Row successfully inserted!", MessageType.Success);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //DataTable AllRequests = ManageEdfDAO.GetAllRequests();

            //foreach (DataRow item in AllRequests.Rows)
            //{
            //    string id = item["id"].ToString();

            //    string CreateDate = ManageEdfDAO.GetCreateDate(id);

            //    ManageEdfDAO.UpdateRequest(id, CreateDate);
            //}
        }
        private SharePointOnlineCredentials LogIn(string url, string login, string password)
        {
            SecureString securePassword = new SecureString();

            foreach (char c in password)
            {
                securePassword.AppendChar(c);
            }
           
            return new SharePointOnlineCredentials(login, securePassword);
        }
    }
}
