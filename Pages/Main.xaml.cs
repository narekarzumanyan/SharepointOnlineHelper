using MahApps.Metro.Controls;
using Microsoft.SharePoint.Client;
using SharepointHelper.Helpers;
using System.Threading;
using System.Windows;
using System.Windows.Controls;

namespace SharepointHelper.Pages
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : MetroWindow
    {
        public Main()
        {
            InitializeComponent();
            SiteTitle.Content = string.Format("Current Site: {0}", "SHarePoint EDF   |");
            User.Content = string.Format("Current User: {0}", "Narek Arzumanyan");
        }

        #region Events
        private void EdfInfo_Click(object sender, RoutedEventArgs e)
        {
            SetMessageInfo("Administrative tool", MessageType.Success);
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            var item = sender as TabControl;
            var selected = item.SelectedItem as TabItem;

            if (ManageEDF.IsSelected)
            {
                ManageEDF curentTab = new ManageEDF();
                if (StkManageEdf.Children.Count == 0)
                    StkManageEdf.Children.Add(curentTab);
            }
            if (TestTab1.IsSelected)
            {
                ManageEDF curentTab = new ManageEDF();
                if (StkTestTab1.Children.Count == 0)
                    StkTestTab1.Children.Add(curentTab);
            }
            if (TestTab2.IsSelected)
            {
                ManageEDF curentTab = new ManageEDF();
                if (StkTestTab2.Children.Count == 0)
                    StkTestTab2.Children.Add(curentTab);
            }
            if (TestTab3.IsSelected)
            {
                ManageEDF curentTab = new ManageEDF();
                if (StkTestTab3.Children.Count == 0)
                    StkTestTab3.Children.Add(curentTab);
            }
            if (TestTab4.IsSelected)
            {
                ManageEDF curentTab = new ManageEDF();
                if (StkTestTab4.Children.Count == 0)
                    StkTestTab4.Children.Add(curentTab);
            }
        }

        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            App.Current.Shutdown();
        }

        #endregion

        #region NotificationLoad

        public Thread StartLoad()
        {
            Thread newWindowLoad = new Thread(new ThreadStart(() =>
            {
                // Create and show the Window
                Load window = new Load();
                var stackPanel = new StackPanel { Orientation = Orientation.Vertical };
                Control.LoadingAnimation loading = new Control.LoadingAnimation();
                stackPanel.Children.Add(loading);
                window.Content = stackPanel;
                window.Show();
                // Start the Dispatcher Processing
                System.Windows.Threading.Dispatcher.Run();
            }));
            // Set the apartment state
            newWindowLoad.SetApartmentState(ApartmentState.STA);
            // Make the thread a background thread
            newWindowLoad.IsBackground = false;
            // Start the thread
            newWindowLoad.Start();

            return newWindowLoad;
        }
        public void StopLoad( Thread LoadThread)
        {
            LoadThread.Abort();
        }

        private string ErrorMessage;
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

    }
}
