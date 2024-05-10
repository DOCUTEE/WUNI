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
    /// Interaction logic for WBookingThisWorker.xaml
    /// </summary>
    public partial class WBookingThisWorker : Window
    {
        public WBookingThisWorker()
        {
            InitializeComponent();
        }
        private string customerID;
        private string workerID;

        public WBookingThisWorker(string customerID, string workerID, DateTime bookingDate)
        {
            InitializeComponent();
            //truyền data vào
            this.customerID = customerID;
            this.workerID = workerID;


            dtpBookingDate.SelectedDate = DateTime.Today;
            dtpBookingDate.DisplayDateStart = DateTime.Today;



            WorkerDAO workerDAO = new WorkerDAO();
            Worker worker = workerDAO.GetWorkerFrom(workerID);
            CustomerDAO customerDAO = new CustomerDAO();
            Customer customer = customerDAO.GetCustomerFrom(customerID);
            FieldDAO fieldDAO = new FieldDAO();
            string fieldName =  fieldDAO.GetFieldFrom(worker.FieldID);
            this.tblCustomerAddress.Text = customer.Address;
            this.tblCustomerName.Text   = customer.Name;
            this.tblField.Text = fieldName;
            this.tblPhoneNumCustomer.Text = customer.PhoneNumber;
            this.tblWorkerName.Text = worker.Name;
            this.tblPhoneNumWorker.Text = worker.PhoneNumber; 
            this.dtpBookingDate.SelectedDate = bookingDate;
            BusyDateDAO busyDateDAO = new BusyDateDAO();
            List<DateTime> busy = busyDateDAO.GetBusyDateOf(this.workerID);
            foreach (var busyDate in busy)
            {
                dtpBookingDate.BlackoutDates.Add(new CalendarDateRange(busyDate));
            }


        }

        private void btnCreateOrder_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //Tạo đơn thành công và gửi đơn vào queue của thợ 
            //copy ảnh này vào IssueImage / <orderID>.png
            MessageBox.Show("Gửi thành công");
            WorkerDAO workerDAO = new WorkerDAO();
            Worker worker = workerDAO.GetWorkerFrom(this.workerID);
            Order order = new Order(
                worker.FieldID,
                this.customerID,
                txbCustomerDescription.Text,
                "",
                dtpBookingDate.SelectedDate.Value,
                this.workerID  
                );
            order.IsQueue = true;
            OrderDAO orderDAO = new OrderDAO();
            orderDAO.Add(order);
            QueueDAO queueDAO = new QueueDAO();
            Queuee queuee = new Queuee(workerID, order.OrderID);
            queueDAO.Add(queuee);

            //Copy and  paste image of the issue into IssueImage Folder
            BitmapImage bitmapImage = issueImage.ImageSource as BitmapImage;
            string originalPath = bitmapImage.UriSource.LocalPath;
            string path = Environment.CurrentDirectory;
            string targetPath = Directory.GetParent(path).Parent.Parent.FullName;
            //MessageBox.Show(targetPath);
            //Create ID for this image
            string imageID = order.IssueImage;
            string destFile = targetPath + imageID;
            System.IO.File.Copy(originalPath, destFile, true);
            this.Close();
        }

        private void btnSelectIssueImage_Click(object sender, RoutedEventArgs e)
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
                issueImage.ImageSource = bitmap;
            }
        }

    }
}
