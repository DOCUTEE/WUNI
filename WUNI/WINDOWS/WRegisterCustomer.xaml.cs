using Microsoft.Win32;
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
using WUNI.DAOClass;

namespace WUNI.WINDOWS
{
    /// <summary>
    /// Interaction logic for WRegisterCustomer.xaml
    /// </summary>
    public partial class WRegisterCustomer : Window
    {
        public WRegisterCustomer()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            //Thịnh code ở đây sao cho thông tin và tài khoản của người dùng lần lượt được lưu vào bảng Customer và CustomerAccount
            Customer customer = new Customer(
            txbCitizenID.Text,
            txbName.Text,
            dtpBirth.SelectedDate.Value,
            cboGender.Text,
            txbAddress.Text,
            txbEmail.Text,
            txbPhoneNumber.Text,
            txbDescription.Text,
            "HUYGA"
            );
        CustomerDAO customerDAO = new CustomerDAO();
        customerDAO.Add(customer);
            //Copy and  paste image of the customer into customerImage Folder
            BitmapImage bitmapImage = imgProfile.Source as BitmapImage;
            string originalPath = bitmapImage.UriSource.LocalPath;
            string path = Environment.CurrentDirectory;
            string targetPath = Directory.GetParent(path).Parent.Parent.FullName;
            MessageBox.Show(targetPath);
            //Create ID for this image
            string imageID = customer.ProfileImage;
            string destFile = targetPath + imageID;
            System.IO.File.Copy(originalPath, destFile, true);
            CustomerAccount customerAccount = new CustomerAccount(
                txbUserName.Text,
                txpPassword.Password.ToString(),
                customer.CustomerID
            );
            CustomerAccountDAO customerAccountDAO = new CustomerAccountDAO();
            customerAccountDAO.Add(customerAccount);
            this.Close();


        }

        private void SelectImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                // Tạo một BitmapImage
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(openFileDialog.FileName);
                bitmap.EndInit();

                // Đặt ảnh cho Image control
                imgProfile.Source = bitmap;
            }
        }

        
    }
}
