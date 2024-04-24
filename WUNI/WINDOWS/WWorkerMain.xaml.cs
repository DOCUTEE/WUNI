using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WUNI.Class;
using WUNI.WINDOWS.WorkerPages;

namespace WUNI.WINDOWS
{
    /// <summary>
    /// Interaction logic for WWorkerMain.xaml
    /// </summary>
    public partial class WWorkerMain : Window
    {
        private string workerID;

        public WWorkerMain()
        {
            InitializeComponent();
            string path = Environment.CurrentDirectory;
            string path1 = Directory.GetParent(path).Parent.Parent.FullName;
            iconFindWork.Source = new BitmapImage(new Uri(path1 + "\\Logo\\FindIcon.png"));
            iconHistory.Source = new BitmapImage(new Uri(path1 + "\\Logo\\HistoryIcon.png"));
            iconAccount.Source = new BitmapImage(new Uri(path1 + "\\Logo\\AccountIcon.png"));
            iconSignOut.Source = new BitmapImage(new Uri(path1 + "\\Logo\\SignOutIcon.png"));
            fContent.NavigationService.Navigate(new PWorkerFindJob());
        }
        public WWorkerMain(string workerID)
        {
            InitializeComponent();
            this.workerID = workerID;
            string path = Environment.CurrentDirectory;
            string path1 = Directory.GetParent(path).Parent.Parent.FullName;
            iconFindWork.Source = new BitmapImage(new Uri(path1 + "\\Logo\\FindIcon.png"));
            iconHistory.Source = new BitmapImage(new Uri(path1 + "\\Logo\\HistoryIcon.png"));
            iconAccount.Source = new BitmapImage(new Uri(path1 + "\\Logo\\AccountIcon.png"));
            iconSignOut.Source = new BitmapImage(new Uri(path1 + "\\Logo\\SignOutIcon.png"));
            fContent.NavigationService.Navigate(new PWorkerFindJob(this.workerID));

        }

        private void btnFindWork_MouseEnter(object sender, MouseEventArgs e)
        {
            SolidColorBrush temp = (SolidColorBrush)new BrushConverter().ConvertFrom("#E4DCCF");
            SolidColorBrush backgroundBrush = btnFindWork.Background as SolidColorBrush;
            if (backgroundBrush != null && backgroundBrush.Color != temp.Color)
            {
                btnFindWork.Background = (Brush)new BrushConverter().ConvertFrom("#EFEFEF");
            }
        }

        private void btnFindWork_MouseLeave(object sender, MouseEventArgs e)
        {
            SolidColorBrush temp = (SolidColorBrush)new BrushConverter().ConvertFrom("#E4DCCF");
            SolidColorBrush backgroundBrush = btnFindWork.Background as SolidColorBrush;
            if (backgroundBrush != null && backgroundBrush.Color != temp.Color)
            { 
                btnFindWork.Background = (Brush)new BrushConverter().ConvertFrom("#F9F5EB");
            }
        }

        private void btnHistory_MouseEnter(object sender, MouseEventArgs e)
        {
            SolidColorBrush temp = (SolidColorBrush)new BrushConverter().ConvertFrom("#E4DCCF");
            SolidColorBrush backgroundBrush = btnHistory.Background as SolidColorBrush;
            if (backgroundBrush != null && backgroundBrush.Color != temp.Color)
            {
                btnHistory.Background = (Brush)new BrushConverter().ConvertFrom("#EFEFEF");
            }
        }

        private void btnHistory_MouseLeave(object sender, MouseEventArgs e)
        {
            SolidColorBrush temp = (SolidColorBrush)new BrushConverter().ConvertFrom("#E4DCCF");
            SolidColorBrush backgroundBrush = btnHistory.Background as SolidColorBrush;
            if (backgroundBrush != null && backgroundBrush.Color != temp.Color)
            {
                btnHistory.Background = (Brush)new BrushConverter().ConvertFrom("#F9F5EB");
            }
        }

        private void btnAccount_MouseEnter(object sender, MouseEventArgs e)
        {
            SolidColorBrush temp = (SolidColorBrush)new BrushConverter().ConvertFrom("#E4DCCF");
            SolidColorBrush backgroundBrush = btnAccount.Background as SolidColorBrush;
            if (backgroundBrush != null && backgroundBrush.Color != temp.Color)
            {
                btnAccount.Background = (Brush)new BrushConverter().ConvertFrom("#EFEFEF");
            }
        }

        private void btnAccount_MouseLeave(object sender, MouseEventArgs e)
        {
            SolidColorBrush temp = (SolidColorBrush)new BrushConverter().ConvertFrom("#E4DCCF");
            SolidColorBrush backgroundBrush = btnAccount.Background as SolidColorBrush;
            if (backgroundBrush != null && backgroundBrush.Color != temp.Color)
            {
                btnAccount.Background = (Brush)new BrushConverter().ConvertFrom("#F9F5EB");
            }
        }

        private void btnSignOut_MouseEnter(object sender, MouseEventArgs e)
        {
            SolidColorBrush temp = (SolidColorBrush)new BrushConverter().ConvertFrom("#E4DCCF");
            SolidColorBrush backgroundBrush = btnSignOut.Background as SolidColorBrush;
            if (backgroundBrush != null && backgroundBrush.Color != temp.Color)
            {
                btnSignOut.Background = (Brush)new BrushConverter().ConvertFrom("#EFEFEF");
            }
        }

        private void btnSignOut_MouseLeave(object sender, MouseEventArgs e)
        {
            SolidColorBrush temp = (SolidColorBrush)new BrushConverter().ConvertFrom("#E4DCCF");
            SolidColorBrush backgroundBrush = btnSignOut.Background as SolidColorBrush;
            if (backgroundBrush != null && backgroundBrush.Color != temp.Color)
            {
                btnSignOut.Background = (Brush)new BrushConverter().ConvertFrom("#F9F5EB");
            }
        }

        private void btnFindWork_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            btnFindWork.Background = (Brush)new BrushConverter().ConvertFrom("#E4DCCF");
            btnHistory.Background = (Brush)new BrushConverter().ConvertFrom("#F9F5EB");
            btnAccount.Background = (Brush)new BrushConverter().ConvertFrom("#F9F5EB");
            fContent.NavigationService.Navigate(new PWorkerFindJob(this.workerID));
        }

        private void btnHistory_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            btnFindWork.Background = (Brush)new BrushConverter().ConvertFrom("#F9F5EB");
            btnHistory.Background = (Brush)new BrushConverter().ConvertFrom("#E4DCCF");
            btnAccount.Background = (Brush)new BrushConverter().ConvertFrom("#F9F5EB");
            fContent.NavigationService.Navigate(new PWorkerHistory(this.workerID));
        }

        private void btnAccount_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            btnFindWork.Background = (Brush)new BrushConverter().ConvertFrom("#F9F5EB");
            btnHistory.Background = (Brush)new BrushConverter().ConvertFrom("#F9F5EB");
            btnAccount.Background = (Brush)new BrushConverter().ConvertFrom("#E4DCCF");
            //fContent.NavigationService.Navigate(new)
        }

        private void btnSignOut_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WLogin wLogin = new WLogin();
            wLogin.Show();
            this.Close();

        }
        
    }
}
