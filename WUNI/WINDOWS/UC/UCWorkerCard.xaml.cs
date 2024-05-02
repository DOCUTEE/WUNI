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
    /// Interaction logic for UCWorkerCard.xaml
    /// </summary>
    public partial class UCWorkerCard : UserControl
    {
        private String workerID;
        private String customerID;
        public UCWorkerCard()
        {
            InitializeComponent();
        }
        public UCWorkerCard(Worker worker, string customerID)
        {
            InitializeComponent();

            string path = Environment.CurrentDirectory;
            string path1 = Directory.GetParent(path).Parent.Parent.FullName;
            this.workerID = worker.WorkerID;
            this.customerID = customerID;
            workerName.Text = worker.Name.ToString();
            workerRating.Text = "Đánh giá: " + worker.Rating.ToString();
            workerAddress.Text = "Địa chỉ: " + worker.Address.ToString();
            lblPhoneNumber.Text ="Số điện thoại: " +  worker.PhoneNumber.ToString();
            imgProfile.ImageSource = new BitmapImage(new Uri(path1 + "\\WorkerImage\\" + worker.WorkerID.ToString() + ".png"));
            workerPrice.Text = worker.PricePerHour.ToString() + "k /Giờ";
            LikedDAO likedDAO = new LikedDAO();
            bool isLiked = likedDAO.isLiked(this.customerID,this.workerID);
            if (isLiked) likeIcon.Source = new BitmapImage(new Uri(path1 + "\\Logo\\HeartRed.png"));
            else likeIcon.Source = new BitmapImage(new Uri(path1 + "\\Logo\\HeartBlank.png"));
        }
        private void btnMore_Click(object sender, RoutedEventArgs e)
        {
            WCustomerMain wCustomerMain = (WCustomerMain)Window.GetWindow(this);
            MessageBox.Show(wCustomerMain.CustomerID);
            WWorkerDetails workerDetails = new WWorkerDetails(wCustomerMain.CustomerID, this.workerID);
            workerDetails.Show();   
        }

        private void likeIcon_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string path = Environment.CurrentDirectory;
            string path1 = Directory.GetParent(path).Parent.Parent.FullName;
            LikedDAO likedDAO = new LikedDAO();
            MessageBox.Show(this.workerID + "|" + this.customerID);
            bool isLiked = likedDAO.isLiked(this.customerID, this.workerID);
            Liked liked = new Liked(this.workerID, this.customerID);
            if (isLiked)
            {
                likeIcon.Source = new BitmapImage(new Uri(path1 + "\\Logo\\HeartBlank.png"));
                likedDAO.Remove(liked);
            }
            else
            {
                likeIcon.Source = new BitmapImage(new Uri(path1 + "\\Logo\\HeartRed.png"));
                likedDAO.Add(liked);
            }
        }
    }
}
