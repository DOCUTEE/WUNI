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
            tblGender.Text = customer.Birth.ToString();
            //Get list liked workers of this customer
            LikedDAO likedDAO = new LikedDAO();
            List<Worker> workers = likedDAO.ListLikedOf(this.customerID);
            foreach(Worker worker in workers)
            {
                UCWorkerCard workerCard = new UCWorkerCard(worker);
                ufgLikedWorker.Children.Add(workerCard);
            }
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

        }
    }
}
