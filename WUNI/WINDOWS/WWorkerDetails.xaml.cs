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
using System.Windows.Shapes;

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
            //truyền data vào page
        }
        

        

        

        private void btnInfo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //bấm vào liên hệ thì mấy trang còn lại hidden
        }
        private void btnDescription_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //bấm vào mô tả thì mấy trang còn lại hidden
        }
        private void btnReviews_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //bấm vào đánh giá thì mấy trang còn lại hidden
        }

        private void btnRegister_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
