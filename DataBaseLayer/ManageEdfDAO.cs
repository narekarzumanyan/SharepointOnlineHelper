using SharepointHelper.Helpers;
using System;
using System.Windows;
using System.Data;

namespace SharepointHelper.DataBaseLayer
{
    class ManageEdfDAO
    {


        public static bool InsertRequest(string typeId, string autorId, string addDate, string state)
        {

            string command = string.Format("INSERT INTO [dbo].[Request] ([Type_id],[Autor_id],[Add_date],[State]) VALUES({0},'{1}','{2}',{3})",
                typeId,
                autorId,
                addDate,
                state
                );
            try
            {
                DBManager.ExecuteNonQuery(command);
                return true;
            }
            catch (Exception ex)
            {
                SetMessageInfo(ex.Message, MessageType.Error);
                return false;
            }
        }
      


        public static bool InsertAppReq(string autorId, string requestId, string state, string addDate, string approveDate, string replaceId, string status)
        {

            string command = string.Format("INSERT INTO [dbo].[Approve_reject]([User_ID],[Request_ID],[App_rej],[Date_add],[App_rej_Date],[Rep_Id],[Status]) VALUES('{0}',{1},{2},'{3}',{4},{5},{6})",
                autorId,
                requestId,
                state,
                addDate,
                (string.IsNullOrEmpty(approveDate)) ? "Null" : "'" + approveDate + "'",
                (string.IsNullOrEmpty(replaceId)) ? "Null" : "'" + replaceId + "'",
                (string.IsNullOrEmpty(status)) ? "Null" : "'" + status + "'"
                );
            try
            {
                DBManager.ExecuteNonQuery(command);
                return true;
            }
            catch (Exception ex)
            {
                SetMessageInfo(ex.Message, MessageType.Error);
                return false;
            }
        }

        public static bool InsertNotification(string userId, string dateAdd, string visited, string visitUrl, string message, string avatar, string typeId)
        {
            string command = string.Format("INSERT INTO [dbo].[Notificaion] ([User_id],[Date_Add],[visited],[Visit_url],[notification],[avatar],[Type_id]) VALUES('{0}','{1}','{2}','{3}','{4}','{5}',{6})",
                userId,
                dateAdd,
                visited,
                visitUrl,
                message,
                avatar,
                typeId
                );
            try
            {
                DBManager.ExecuteNonQuery(command);
                return true;
            }
            catch (Exception ex)
            {
                SetMessageInfo(ex.Message, MessageType.Error);
                return false;
            }
        }

        private static void SetMessageInfo(string message, MessageType msgType)
        {
            switch (msgType)
            {
                case MessageType.Success:
                    MessageBox.Show(message, "Success!!!", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                case MessageType.Error:
                    MessageBox.Show(message, "Error!!!", MessageBoxButton.OK, MessageBoxImage.Error);
                    break;
                default:
                    MessageBox.Show(message, "Info!!!", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
            }
        }

        internal static DataTable GetAllRequests()
        {
            DataTable table = null;
            string command = "select * from [dbo].[Request] where [Type_id]='6' ";
            try
            {
                table = DBManager.ExecuteQueryDataTable(command);
            }
            catch (Exception ex)
            {

            }
            return table;
        }

        internal static string GetCreateDate(string id)
        {
            DataTable table = null;
            string command = string.Format("select FillingDate from StockOutRequest where RequestId={0}", id);
            try
            {
                table = DBManager.ExecuteQueryDataTable(command);
            }
            catch (Exception ex)
            {

            }
            if (table.Rows.Count > 0)
                return table.Rows[0][0].ToString();
            else
                return DateTime.MinValue.ToString();
        }

        public static bool UpdateRequest(string ID, string addDate)
        {

            string command = string.Format("UPDATE [dbo].[Request] SET [Add_date]= '{0}' WHERE ID={1}",
                addDate,
                ID);
            try
            {
                DBManager.ExecuteNonQuery(command);
                return true;
            }
            catch (Exception ex)
            {
                SetMessageInfo(ex.Message, MessageType.Error);
                return false;
            }
        }
    }
}
