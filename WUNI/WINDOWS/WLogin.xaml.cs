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
using WUNI.DAOClass;

namespace WUNI.WINDOWS
{
    /// <summary>
    /// Interaction logic for WLogin.xaml
    /// </summary>
    public partial class WLogin : Window
    {
        public WLogin()
        {
            InitializeComponent();
            string path = Environment.CurrentDirectory;
            string path2 = Directory.GetParent(path).Parent.Parent.FullName + "\\Logo\\Wuni.jpg";
            imgBrand.Source = new BitmapImage(new Uri(path2));
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            WWhoRegister wWhoRegister = new WWhoRegister(); 
            wWhoRegister.Show();
        }

        private void btnLoginWorker_Click(object sender, RoutedEventArgs e)
        {
            //Thịnh code đăng nhập để kiểm tra xem tài khoản đã tồn tại hay chưa nếu rồi thì vào window WWorkerMain.xaml
        }

        private void btnLoginCustomer_Click(object sender, RoutedEventArgs e)
        {
            //Thịnh code đăng nhập để kiểm tra xem tài khoản đã tồn tại hay chưa nếu rồi thì vào window WCustomerMain.xaml            
        }
    }
}
