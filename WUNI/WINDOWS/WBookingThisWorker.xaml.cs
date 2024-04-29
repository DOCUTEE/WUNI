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
using WUNI.Class;

namespace WUNI.WINDOWS
{
    /// <summary>
    /// Interaction logic for WBookingThisWorker.xaml
    /// </summary>
    public partial class WBookingThisWorker : Window
    {
        public WBookingThisWorker()
        {
            InitializeComponent();
        }
        public WBookingThisWorker(string customerID, string workerID, DateTime bookingDate)
        {
            InitializeComponent();
            //truyền data vào
            
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            //Tạo đơn thành công và gửi đơn vào queue của thợ 
            //copy ảnh này vào IssueImage / <orderID>.png
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Mở cửa số của lấy ảnh, và truyền ảnh vừa lấy lên issueImage, copy ảnh này vào IssueImage/orderID
        }
    }
}
