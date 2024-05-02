using System;
using System.Collections.Generic;
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
using WUNI.DAOClass;
using WUNI.Class;
using WUNI.WINDOWS.UC;
using System.IO;

namespace WUNI.WINDOWS.CustomerPages
{
    /// <summary>
    /// Interaction logic for PCustomerInformation.xaml
    /// </summary>
    public partial class PCustomerInformation : Page
    {
        private string customerID;
        public PCustomerInformation()
        {
            InitializeComponent();
            this.customerID = "1";
            CustomerDAO customerDAO = new CustomerDAO();
            Customer customer = customerDAO.GetCustomerFrom(this.customerID);
            tblCustomerName.Text = customer.Name;
            tblDescription.Text = customer.Description;
            tblPhoneNumber.Text = customer.PhoneNumber;
            tblAddress.Text = customer.Address;
            tblEmail.Text = customer.Mail;
            tblGender.Text = customer.Gender;
            tblGender.Text = customer.Birth.ToString();
            //Get list liked workers of this customer
            LikedDAO likedDAO = new LikedDAO();
            List<Worker> workers = likedDAO.ListLikedOf(this.customerID);
            foreach (Worker worker in workers)
            {
                UCWorkerCard workerCard = new UCWorkerCard(worker, this.customerID);
                ufgLikedWorker.Children.Add(workerCard);
            }
        }
        public PCustomerInformation(string customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
            CustomerDAO customerDAO = new CustomerDAO();
            Customer customer = customerDAO.GetCustomerFrom(this.customerID);
            tblCustomerName.Text = customer.Name;
            tblDescription.Text = customer.Description;
            tblPhoneNumber.Text = customer.PhoneNumber;
            tblAddress.Text = customer.Address;
            tblEmail.Text = customer.Mail;
            tblGender.Text = customer.Gender;

            string path = Environment.CurrentDirectory;
            string path1 = Directory.GetParent(path).Parent.Parent.FullName;
            imgCustomerProfile.ImageSource = new BitmapImage(new Uri(path1 + customer.ProfileImage));
            tblBirth.Text = customer.Birth.ToString();
        }

        private void btnInfo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            containerInfo.Visibility = Visibility.Visible;
            containerLikedWorker.Visibility = Visibility.Hidden;

        }

        private void btnLiked_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            containerInfo.Visibility = Visibility.Hidden;
            containerLikedWorker.Visibility = Visibility.Visible;
            ufgLikedWorker.Children.Clear();
            LikedDAO likedDAO = new LikedDAO();
            List<Worker> workers = likedDAO.ListLikedOf(this.customerID);
            foreach (Worker worker in workers)
            {
                UCWorkerCard workerCard = new UCWorkerCard(worker, this.customerID);
                ufgLikedWorker.Children.Add(workerCard);
            }
        }
    }
}
