using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
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
using WUNI.WINDOWS.WorkerPages;
using WUNI.WINDOWS.CustomerPages;

namespace WUNI.WINDOWS
{
    /// <summary>
    /// Interaction logic for WCustomerMain.xaml
    /// </summary>
    public partial class WCustomerMain : Window
    {
        private string customerID;
        public WCustomerMain()
        {
            InitializeComponent();
        }
        public WCustomerMain(string customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
            string path = Environment.CurrentDirectory;
            string path1 = Directory.GetParent(path).Parent.Parent.FullName;
            iconFindWork.Source = new BitmapImage(new Uri(path1 + "\\Logo\\FindIcon.png"));
            iconCreateOrder.Source = new BitmapImage(new Uri(path1 + "\\Logo\\FindIcon.png"));
            iconHistory.Source = new BitmapImage(new Uri(path1 + "\\Logo\\HistoryIcon.png"));
            iconAccount.Source = new BitmapImage(new Uri(path1 + "\\Logo\\AccountIcon.png"));
            iconSignOut.Source = new BitmapImage(new Uri(path1 + "\\Logo\\SignOutIcon.png"));
            fContent.NavigationService.Navigate(new PCustomerServices(this.customerID));
        }
        private void btnFindService_MouseEnter(object sender, MouseEventArgs e)
        {
            SolidColorBrush temp = (SolidColorBrush)new BrushConverter().ConvertFrom("#E4DCCF");
            SolidColorBrush backgroundBrush = btnFindService.Background as SolidColorBrush;
            if (backgroundBrush != null && backgroundBrush.Color != temp.Color)
            {
                btnFindService.Background = (Brush)new BrushConverter().ConvertFrom("#EFEFEF");
            }
        }

        private void btnFindService_MouseLeave(object sender, MouseEventArgs e)
        {
            SolidColorBrush temp = (SolidColorBrush)new BrushConverter().ConvertFrom("#E4DCCF");
            SolidColorBrush backgroundBrush = btnFindService.Background as SolidColorBrush;
            if (backgroundBrush != null && backgroundBrush.Color != temp.Color)
            {
                btnFindService.Background = (Brush)new BrushConverter().ConvertFrom("#F9F5EB");
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

        private void btnFindService_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            btnFindService.Background = (Brush)new BrushConverter().ConvertFrom("#E4DCCF");
            btnCreateOrder.Background = (Brush)new BrushConverter().ConvertFrom("#F9F5EB");
            btnHistory.Background = (Brush)new BrushConverter().ConvertFrom("#F9F5EB");
            btnAccount.Background = (Brush)new BrushConverter().ConvertFrom("#F9F5EB");
            //Thịnh
        }

        private void btnHistory_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            btnFindService.Background = (Brush)new BrushConverter().ConvertFrom("#F9F5EB");
            btnCreateOrder.Background = (Brush)new BrushConverter().ConvertFrom("#F9F5EB");
            btnHistory.Background = (Brush)new BrushConverter().ConvertFrom("#E4DCCF");
            btnAccount.Background = (Brush)new BrushConverter().ConvertFrom("#F9F5EB");
            //Thịnh
        }

        private void btnAccount_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            btnFindService.Background = (Brush)new BrushConverter().ConvertFrom("#F9F5EB");
            btnCreateOrder.Background = (Brush)new BrushConverter().ConvertFrom("#F9F5EB");
            btnHistory.Background = (Brush)new BrushConverter().ConvertFrom("#F9F5EB");
            btnAccount.Background = (Brush)new BrushConverter().ConvertFrom("#E4DCCF");
            //Thịnh
            
        }
        private void btnSignOut_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WLogin wLogin = new WLogin();
            wLogin.Show();
            this.Close();
        }

        private void btnCreateOrder_MouseEnter(object sender, MouseEventArgs e)
        {
            SolidColorBrush temp = (SolidColorBrush)new BrushConverter().ConvertFrom("#E4DCCF");
            SolidColorBrush backgroundBrush = btnCreateOrder.Background as SolidColorBrush;
            if (backgroundBrush != null && backgroundBrush.Color != temp.Color)
            {
                btnCreateOrder.Background = (Brush)new BrushConverter().ConvertFrom("#EFEFEF");
            }
        }

        private void btnCreateOrder_MouseLeave(object sender, MouseEventArgs e)
        {
            SolidColorBrush temp = (SolidColorBrush)new BrushConverter().ConvertFrom("#E4DCCF");
            SolidColorBrush backgroundBrush = btnCreateOrder.Background as SolidColorBrush;
            if (backgroundBrush != null && backgroundBrush.Color != temp.Color)
            {
                btnCreateOrder.Background = (Brush)new BrushConverter().ConvertFrom("#F9F5EB");
            }
        }

        private void btnCreateOrder_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            btnFindService.Background = (Brush)new BrushConverter().ConvertFrom("#F9F5EB");
            btnCreateOrder.Background = (Brush)new BrushConverter().ConvertFrom("#E4DCCF");
            btnHistory.Background = (Brush)new BrushConverter().ConvertFrom("#F9F5EB");
            btnAccount.Background = (Brush)new BrushConverter().ConvertFrom("#F9F5EB");
            //Thịnh
        }
    }
}
