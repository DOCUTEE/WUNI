using Microsoft.Win32;
using System;
using System.Collections;
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
    /// Interaction logic for WReviewOrder.xaml
    /// </summary>
    public partial class WReviewOrder : Window
    {
        private string orderID;
        private List<Image> stars;
        private int starNum;
        public WReviewOrder()
        {
            InitializeComponent();
            string path = Environment.CurrentDirectory;
            string targetPath = Directory.GetParent(path).Parent.Parent.FullName;
            List<Image> stars = new List<Image>();
            for (int i = 0; i < 5; i++)
            {
                Image star = new Image();

                star.Source = new BitmapImage(new Uri(targetPath + "\\Logo\\StarGrey.png"));
                star.MouseLeftButtonDown += Star_MouseLeftButtonDown;
                Grid.SetColumn(star, i); // Đặt cột cho hình ngôi sao
                stars.Add(star);
            }
            foreach (var star in stars)
            {
                starRating.Children.Add(star);
            }
            this.stars = stars;
        }
        public WReviewOrder(string orderID)
        {
            InitializeComponent();
            this.orderID = orderID;
            this.starNum = 0;
            string path = Environment.CurrentDirectory;
            string targetPath = Directory.GetParent(path).Parent.Parent.FullName;
            List<Image> stars = new List<Image>();
            for (int i = 0; i < 5; i++)
            {
                Image star = new Image();
                
                star.Source = new BitmapImage(new Uri(targetPath + "\\Logo\\StarGrey.png"));
                star.MouseLeftButtonDown += Star_MouseLeftButtonDown;
                Grid.SetColumn(star, i); // Đặt cột cho hình ngôi sao
                stars.Add(star);
            }
            foreach (var star in stars)
            {
                starRating.Children.Add(star);
            }
            this.stars = stars;
        }
        private void Star_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Image clickedStar = sender as Image;
            int index = stars.IndexOf(clickedStar);
            this.starNum = index + 1;
            for (int i = 0; i <= index; i++)
            {
                string path = Environment.CurrentDirectory;
                string targetPath = Directory.GetParent(path).Parent.Parent.FullName;
                stars[i].Source = new BitmapImage(new Uri(targetPath + "\\Logo\\StarYellow.png"));
            }
            for (int i = index + 1; i < stars.Count; i++)
            {
                string path = Environment.CurrentDirectory;
                string targetPath = Directory.GetParent(path).Parent.Parent.FullName;
                stars[i].Source = new BitmapImage(new Uri(targetPath + "\\Logo\\StarGrey.png"));
            }
        }

        private void btnReview_Click(object sender, RoutedEventArgs e)
        {
            //Task: Đóng gói thành review rồi add vào database rồi đóng cửa sổ này
            OrderDAO orderDAO = new OrderDAO();
            Order order =orderDAO.GetOrderFrom(this.orderID);
            Review review = new Review(this.orderID,
                order.CustomerID,
                order.WorkerID,
                txbCustomerDescription.Text,
                "",
                this.starNum
                );
            ReviewDAO reviewDAO = new ReviewDAO();
            //Copy and  paste image of the customer into customerImage Folder
            BitmapImage bitmapImage = issueImage.ImageSource as BitmapImage;
            string originalPath = bitmapImage.UriSource.LocalPath;
            string path = Environment.CurrentDirectory;
            string targetPath = Directory.GetParent(path).Parent.Parent.FullName;
            MessageBox.Show(targetPath);
            //Create ID for this image
            string imageID = order.OrderID;
            string destFile = targetPath + imageID;
            reviewDAO.Add(review);
        }

        private void btnChooseImage_Click(object sender, RoutedEventArgs e)
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
