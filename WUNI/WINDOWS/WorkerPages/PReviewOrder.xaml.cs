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
namespace WUNI.WINDOWS.WorkerPages
{
    /// <summary>
    /// Interaction logic for PReviewOrder.xaml
    /// </summary>
    public partial class PReviewOrder : Page
    {
        private Order order;
        private Review review;
        public PReviewOrder()
        {
            InitializeComponent();
            
        }
        public PReviewOrder(Order order, Review review)
        {
            this.order = order;
            this.review = review;
            InitializeComponent();
            string path = Environment.CurrentDirectory;
            string path1 = Directory.GetParent(path).Parent.Parent.FullName;
            issueImage.ImageSource = new BitmapImage(new Uri(path1 + this.order.IssueImage));
            reviewImage.ImageSource = new BitmapImage(new Uri(path1 + this.review.ReviewImage));
            txbField.Text = this.order.GetFieldName();
            txbDescription.Text = "Mô tả: " + this.order.Description;
            txbCustomerName.Text = "Tên khách hàng: " + this.order.GetCustomerName();
            txbAddress.Text = "Địa chỉ: " + this.order.GetAddress();
            txbPhoneNumber.Text = "Số điện thoại: " + this.order.GetPhoneNumber();
            txbIssueDate.Text = "Ngày đăng: " + this.order.IssueDate.ToString();
            int starNumber = this.review.StarNumber;
            for(int i = 0; i < starNumber; i++)
            {
                Image image = new Image();
                image.Source = new BitmapImage(new Uri(path1 + "\\Logo\\StarIcon.png"));
                Grid.SetColumn(image, i);
                starContainer.Children.Add(image);
            }
            txbComment.Text = this.review.Comment;
        }
    }
}
