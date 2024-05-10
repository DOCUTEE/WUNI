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
            //string path = Environment.CurrentDirectory;
            //string path2 = Directory.GetParent(path).Parent.Parent.FullName + "\\Logo\\Wuni.jpg";
            //imgBrand.Source = new BitmapImage(new Uri(path2));
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            WWhoRegister wWhoRegister = new WWhoRegister(); 
            wWhoRegister.Show();
        }

        private void btnLoginWorker_Click(object sender, RoutedEventArgs e)
        {
            WorkerAccountDAO workerAccountDAO = new WorkerAccountDAO();
            string workedID = workerAccountDAO.GetWorkerID(txbUsername.Text, pwbPassword.Password.ToString());
            if (workedID != "0")
            {
                WWorkerMain wWorkerMain = new WWorkerMain(workedID);
                //MessageBox.Show(workedID.ToString());
                wWorkerMain.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai tên tài khoản hoặc mật khẩu");
            }
        }

        private void btnLoginCustomer_Click(object sender, RoutedEventArgs e)
        {
            CustomerAccountDAO customerAccountDAO = new CustomerAccountDAO();
            string customerID = customerAccountDAO.GetCustomerID(txbUsername.Text, pwbPassword.Password.ToString());
            if (customerID != "0")
            {
                WCustomerMain wCustomerMain = new WCustomerMain(customerID); ;
                //MessageBox.Show(customerID.ToString());
                wCustomerMain.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai tên tài khoản hoặc mật khẩu");
            }
        }
    }
}
