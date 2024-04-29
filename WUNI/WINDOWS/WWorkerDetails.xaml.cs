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
using WUNI.Class;
using System.Data.Common;
using WUNI.WINDOWS.UC;
namespace WUNI.WINDOWS
{
    /// <summary>
    /// Interaction logic for WWorkerDetails.xaml
    /// </summary>
    public partial class WWorkerDetails : Window
    {
        private string customerID;
        private string workerID;

        public WWorkerDetails()
        {
            InitializeComponent();
        }
        public WWorkerDetails(string customerID,string workerID)
        {
            InitializeComponent();
            this.customerID = customerID;
            this.workerID = workerID;
            WorkerDAO workerDAO = new WorkerDAO();
            Worker worker = workerDAO.GetWorkerFrom(this.workerID);
            string path = Environment.CurrentDirectory;
            string path1 = Directory.GetParent(path).Parent.Parent.FullName;
            imgProfile.ImageSource = new BitmapImage(new Uri(path1 + worker.ProfileImage));
            tblWorkerName.Text = worker.Name;
            FieldDAO fieldDAO = new FieldDAO();
            tblField.Text = fieldDAO.GetFieldFrom(worker.FieldID);
            ReviewDAO reviewDAO = new ReviewDAO();
            tblRating.Text = reviewDAO.StarAvgOf(this.workerID).ToString() + "/5";
            //Move busydate into dtpBookingDate
            BusyDateDAO busyDateDAO = new BusyDateDAO();
            List<DateTime>busy = busyDateDAO.GetBusyDateOf(this.workerID);
            foreach(var busyDate in busy)
            {
                dtpBookingDate.BlackoutDates.Add(new CalendarDateRange( busyDate));
            }
            tblPhoneNumber.Text = worker.PhoneNumber;
            tblAddress.Text = worker.Address;
            tblEmail.Text = worker.PhoneNumber;
            tblGender.Text = worker.Gender;
            tblBirth.Text = worker.Birth.ToString();
            tblDescription.Text = worker.Description;
        }
        

        

        

        private void btnInfo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //bấm vào liên hệ thì mấy trang còn lại hidden
            // Truyền data vào grid này luôn
            containerInfo.Visibility = Visibility.Visible;
            containerDescription.Visibility = Visibility.Hidden;
            containerReviews.Visibility = Visibility.Hidden;
            
        }
        private void btnDescription_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //bấm vào mô tả thì mấy trang còn lại hidden
            // Truyền data vào grid này luôn
            containerInfo.Visibility = Visibility.Hidden;
            containerDescription.Visibility = Visibility.Visible;
            containerReviews.Visibility = Visibility.Hidden;
            
        }
        private void btnReviews_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //bấm vào đánh giá thì mấy trang còn lại hidden
            //này đợi t code xong cái UCReview rồi làm tiếp
            containerInfo.Visibility = Visibility.Hidden;
            containerDescription.Visibility = Visibility.Hidden;
            containerReviews.Visibility = Visibility.Visible;
            ReviewDAO reviewDAO = new ReviewDAO();
            List<Review> reviews = reviewDAO.GetReviewFromWoker(this.workerID);
            ufgReviews.Children.Clear();
            foreach(Review review in reviews)
            {
                UCReview uCReview = new UCReview(review);
                ufgReviews.Children.Add(uCReview);
            }
            
        }

        private void btnRegister_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            if (dtpBookingDate.SelectedDate != null)
            {
                //nhảy ra window tạo đơn WBookingThisWorker(string customerID, string workerID, DateTime bookingDate)
            }
        }
    }
}
