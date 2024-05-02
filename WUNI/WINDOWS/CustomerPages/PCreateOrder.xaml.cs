using Microsoft.Win32;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using WUNI.Class;
using WUNI.DAOClass;
using System.Xml.Linq;

namespace WUNI.WINDOWS.CustomerPages
{
    /// <summary>
    /// Interaction logic for PCreateOrder.xaml
    /// </summary>
    public partial class PCreateOrder : Page
    {
        private string customerID;
        public PCreateOrder()
        {
            InitializeComponent();
        }
        public PCreateOrder(string customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
            //Huy: Truyền data vào
            CustomerDAO customerDAO = new CustomerDAO();
            Customer customer = new Customer();

            customer = customerDAO.GetCustomerFrom(this.customerID);

            tblCustomerName.Text = customer.Name;
            tblCustomerAddress.Text = customer.Address;
            tblCustomerPhoneNumber.Text = customer.PhoneNumber;


            FieldDAO fieldDAO = new FieldDAO();
            List<string> fields = fieldDAO.getAllService();
            foreach (string field in fields)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = field;
                cboField.Items.Add(item);
            }


        }
        private void btnSelectIssueImage_Click(object sender, RoutedEventArgs e)
        {
            //Huy: Chọn ảnh
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(openFileDialog.FileName);
                bitmap.EndInit();
                issueImage.ImageSource = bitmap;
            }
        }

        private void btnCreateOrder_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //Huy: tạo đơn
            FieldDAO fieldDAO = new FieldDAO();
            Order order = new Order(
            fieldDAO.GetIDFieldFrom(cboField.Text),
            this.customerID,
            txbCustomerDescription.Text,
            "mimi",
            dtpBookingDate.SelectedDate.Value,
            "-1"
           );
            OrderDAO orderDAO = new OrderDAO();
            orderDAO.Add(order);
            BitmapImage bitmapImage = issueImage.ImageSource as BitmapImage;
            string originalPath = bitmapImage.UriSource.LocalPath;
            string path = Environment.CurrentDirectory;
            string targetPath = Directory.GetParent(path).Parent.Parent.FullName;
            MessageBox.Show(targetPath);
            //Create ID for this image
            string imageID = order.IssueImage;
            string destFile = targetPath + imageID;
            System.IO.File.Copy(originalPath, destFile, true);
        }
    }
}
