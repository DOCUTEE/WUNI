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
    /// Interaction logic for UCCustomerReviewOrder.xaml
    /// </summary>
    public partial class UCCustomerReviewOrder : UserControl
    {
        public string orderID;
        public UCCustomerReviewOrder()
        {
            InitializeComponent();
        }
        public UCCustomerReviewOrder(Order order)
        {
            InitializeComponent();
            //Task: Truyền data vào đây
            this.orderID = order.OrderID;
            FieldDAO fieldDAO = new FieldDAO();
            WorkerDAO workerDAO = new WorkerDAO();
            Worker worker = workerDAO.GetWorkerFrom(order.WorkerID);
            txbDescription.Text =order.Description;
            txbField.Text = fieldDAO.GetFieldFrom(order.FieldID);
            txbWorkerName.Text = worker.Name;
            txbWorkerPhoneNumber.Text = worker.PhoneNumber;
            string path = Environment.CurrentDirectory;
            string path1 = Directory.GetParent(path).Parent.Parent.FullName;
            issueImage.ImageSource = new BitmapImage(new Uri(path1 + order.IssueImage));
            txbIssueDate.Text = order.IssueDate.ToString();
        }

        private void btnReview_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //Task: Mở cửa số WReviewOrder để đánh giá
            WReviewOrder wReviewOrder = new WReviewOrder(orderID);
            wReviewOrder.Show();

        }
    }
}
