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
namespace WUNI.WINDOWS
{
    /// <summary>
    /// Interaction logic for WWorkerDetails.xaml
    /// </summary>
    public partial class WWorkerDetails : Window
    {
        private string workerID;
        public WWorkerDetails()
        {
            InitializeComponent();
        }
        public WWorkerDetails(string workerID)
        {
            InitializeComponent();
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
            
        }
        

        

        

        private void btnInfo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //bấm vào liên hệ thì mấy trang còn lại hidden
            // Truyền data vào grid này luôn
        }
        private void btnDescription_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //bấm vào mô tả thì mấy trang còn lại hidden
            // Truyền data vào grid này luôn
        }
        private void btnReviews_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //bấm vào đánh giá thì mấy trang còn lại hidden
            //này đợi t code xong cái UCReview rồi làm tiếp
        }

        private void btnRegister_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
