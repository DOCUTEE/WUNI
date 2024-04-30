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
        }

        private void btnChooseImage_Click(object sender, RoutedEventArgs e)
        {
            //Task: Chọn ảnh sau khi đã làm xong
        }
    }
}
