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
    /// Interaction logic for UCReview.xaml
    /// </summary>
    public partial class UCReview : UserControl
    {
        public UCReview()
        {
            InitializeComponent();
        }
        public UCReview(Review review)
        {
            InitializeComponent();
            CustomerDAO customerDAO = new CustomerDAO();
            Customer customer = customerDAO.GetCustomerFrom(review.CustomerID);
            tblCustomerName.Text = customer.Name;
            int starNum = review.StarNumber;
            string path = Environment.CurrentDirectory;
            string path1 = Directory.GetParent(path).Parent.Parent.FullName;
            
            for (int i = 0; i < starNum; i++)
            {
                Image star = new Image();
                star.Source = new BitmapImage(new Uri(path1 + "\\Logo\\StarIcon.png"));
                Grid.SetColumn(star, i);
                starContainer.Children.Add(star);
            }
            tblComment.Text = review.Comment;
            imgReview.ImageSource = new BitmapImage(new Uri(path1 + review.ReviewImage));
        }
    }
}
