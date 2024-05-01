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

namespace WUNI.WINDOWS.CustomerPages
{
    /// <summary>
    /// Interaction logic for PCreateOrder.xaml
    /// </summary>
    public partial class PCreateOrder : Page
    {
        private string customerID;
        public PCreateOrder()
        {
            InitializeComponent();
        }
        public PCreateOrder(string customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
            //Huy: Truyền data vào
        }
        private void btnSelectIssueImage_Click(object sender, RoutedEventArgs e)
        {
            //Huy: Chọn ảnh
        }

        private void btnCreateOrder_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //Huy: tạo đơn
        }
    }
}
