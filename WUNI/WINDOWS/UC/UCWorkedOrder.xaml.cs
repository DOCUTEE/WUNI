using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
using WUNI.WINDOWS.WorkerPages;
using WUNI.DAOClass;
using WUNI.WINDOWS;
namespace WUNI.WINDOWS.UC
{
    /// <summary>
    /// Interaction logic for UCWorkedOrder.xaml
    /// </summary>
    public partial class UCWorkedOrder : UserControl
    {
        private Order order;
        private string workerID;
        public UCWorkedOrder()
        {
            InitializeComponent();
        }
        public UCWorkedOrder(Order order, string workerID)
        {
            InitializeComponent();
            this.order = order;
            this.workerID = workerID;
            string path = Environment.CurrentDirectory;
            string path1 = Directory.GetParent(path).Parent.Parent.FullName;
            issueImage.ImageSource = new BitmapImage(new Uri(path1 + this.order.IssueImage));
            txbField.Text = this.order.GetFieldName();
            txbDescription.Text = "Mô tả: " + this.order.Description;
            txbCustomerName.Text = "Tên khách hàng: " + this.order.GetCustomerName();
            txbAddress.Text = "Địa chỉ: " + this.order.GetAddress();
            txbPhoneNumber.Text = "Số điện thoại: " + this.order.GetPhoneNumber();
            txbIssueDate.Text = "Ngày đăng: " + this.order.IssueDate.ToString();
        }

        private void btnViewReview_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ReviewDAO reviewDAO = new ReviewDAO();
            Review review = reviewDAO.GetReviewFrom(this.order.OrderID);
            //Find WWorkerMain.xaml
            FrameworkElement frameworkElement = this as FrameworkElement;
            while(frameworkElement.GetType().ToString() != new WWorkerMain().GetType().ToString())
            {
                frameworkElement = VisualTreeHelper.GetParent(frameworkElement) as FrameworkElement;
            }
            WWorkerMain wWorkerMain = (WWorkerMain)frameworkElement;
            wWorkerMain.fContent.NavigationService.Navigate(new PReviewOrder(this.order,review));
            
        }
    }
}
