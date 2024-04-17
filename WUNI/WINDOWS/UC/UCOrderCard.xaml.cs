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

namespace WUNI.WINDOWS.UC
{
    /// <summary>
    /// Interaction logic for UCOrderCard.xaml
    /// </summary>
    public partial class UCOrderCard : UserControl
    {
        private Order order;
        public UCOrderCard()
        {
            InitializeComponent();
            string path = Environment.CurrentDirectory;
            string path1 = Directory.GetParent(path).Parent.Parent.FullName;
            issueImage.ImageSource = new BitmapImage(new Uri(path1 + "\\Logo\\WUNI.jpg"));
        }
        public UCOrderCard(Order order)
        {
            InitializeComponent();
            string path = Environment.CurrentDirectory;
            string path1 = Directory.GetParent(path).Parent.Parent.FullName;
            this.order = order;
            issueImage.ImageSource = new BitmapImage(new Uri(path1 + this.order.IssueImage));
            txbField.Text = this.order.GetFieldOfOrder();
            txbDescription.Text = "Mô tả: " +  this.order.Description;
            txbCustomerName.Text = "Tên khách hàng: " + this.order.GetCustomerName();
            txbAddress.Text = "Địa chỉ: " + this.order.GetAddress();
            txbPhoneNumber.Text = "Số điện thoại: " + this.order.getPhoneNumber();
            txbIssueDate.Text = "Ngày đăng: " + this.order.IssueDate.ToString();
        }
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            btnConfirm.Background = (Brush)new BrushConverter().ConvertFrom("#F5F5F5");
            lblConfirm.Foreground = (Brush)new BrushConverter().ConvertFrom("#000000");
            lblConfirm.Content = "Đã nhận";
            //Thịnh
            
        }
    }
}
