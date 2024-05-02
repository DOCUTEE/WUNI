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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WUNI.Class;
using WUNI.DAOClass;

namespace WUNI.WINDOWS.UC
{
    /// <summary>
    /// Interaction logic for UCCardBookingMe.xaml
    /// </summary>
    public partial class UCCardBookingMe : UserControl
    {
        private Order order;
        private string workerID;
        public UCCardBookingMe()
        {
            InitializeComponent();
        }
        public UCCardBookingMe(Order order,string workerID)
        {
            InitializeComponent();
            string path = Environment.CurrentDirectory;
            string path1 = Directory.GetParent(path).Parent.Parent.FullName;
            this.order = order;
            this.workerID = workerID;
            issueImage.ImageSource = new BitmapImage(new Uri(path1 + this.order.IssueImage));
            txbField.Text = this.order.GetFieldName();
            txbDescription.Text = "Mô tả: " + this.order.Description;
            txbCustomerName.Text = "Tên khách hàng: " + this.order.GetCustomerName();
            txbAddress.Text = "Địa chỉ: " + this.order.GetAddress();
            txbPhoneNumber.Text = "Số điện thoại: " + this.order.GetPhoneNumber();
            txbIssueDate.Text = "Ngày đăng: " + this.order.IssueDate.ToString();

        }

        private void btnConfirm_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            btnConfirm.Background = (Brush)new BrushConverter().ConvertFrom("#F5F5F5");
            lblConfirm.Foreground = (Brush)new BrushConverter().ConvertFrom("#000000");
            lblConfirm.Content = "Đã nhận";
            //Thịnh làm xác nhận như mẫu UCOrderCard.xaml.cs
            BusyDate busyDate = new BusyDate(
               this.workerID,
               this.order.CustomerID,
               this.order.IssueDate
           );
            BusyDateDAO busyDateDAO = new BusyDateDAO();
            busyDateDAO.Add(busyDate);
            Worked worked = new Worked(
                this.order.OrderID,
                this.workerID
            );

            WorkedDAO workedDAO = new WorkedDAO();
            workedDAO.Add(worked);
            OrderDAO orderDAO = new OrderDAO();
            //MessageBox.Show(order.OrderID);
            orderDAO.UpdateIsWorked(order.OrderID);
        }
    }
}
