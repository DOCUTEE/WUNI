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

namespace WUNI.WINDOWS.WorkerPages
{
    /// <summary>
    /// Interaction logic for PWorkerInformation.xaml
    /// </summary>
    public partial class PWorkerInformation : Page
    {
        private string workerID;
        public PWorkerInformation()
        {
            InitializeComponent();
        }
        public PWorkerInformation(string workerID)
        {
            InitializeComponent();
            this.workerID = workerID;
            WorkerDAO workerDAO = new WorkerDAO();
            Worker worker = workerDAO.GetWorkerFrom(this.workerID);
            tblWorkerName.Text = worker.Name;
            FieldDAO fieldDAO = new FieldDAO();
            tblField.Text = fieldDAO.GetFieldFrom(worker.FieldID);
            ReviewDAO reviewDAO = new ReviewDAO();
            tblRating.Text = reviewDAO.StarAvgOf(this.workerID).ToString() + "/5";
            tblPhoneNumber.Text = worker.PhoneNumber;
            tblAddress.Text = worker.Address;
            tblEmail.Text = worker.Mail;
            tblGender.Text = worker.Gender;
            tblBirth.Text = worker.Birth.ToString();
            tblDescription.Text = worker.Description;
            string path = Environment.CurrentDirectory;
            string path1 = Directory.GetParent(path).Parent.Parent.FullName;
            imgWorkerProfile.ImageSource = new BitmapImage(new Uri(path1 + worker.ProfileImage));
        }
        private void btnInfo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            containerDescription.Visibility = Visibility.Hidden;
            containerInfo.Visibility = Visibility.Visible;
        }

        private void btnDescription_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            containerDescription.Visibility = Visibility.Visible;
            containerInfo.Visibility = Visibility.Hidden;
        }
    }
    

}
