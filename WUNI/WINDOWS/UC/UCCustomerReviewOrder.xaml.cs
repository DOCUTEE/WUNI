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
using WUNI.Class;

namespace WUNI.WINDOWS.UC
{
    /// <summary>
    /// Interaction logic for UCCustomerReviewOrder.xaml
    /// </summary>
    public partial class UCCustomerReviewOrder : UserControl
    {
        public string orderID;
        public UCCustomerReviewOrder()
        {
            InitializeComponent();
        }
        public UCCustomerReviewOrder(Order order)
        {
            InitializeComponent();
            //Task: Truyền data vào đây
        }

        private void btnReview_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //Task: Mở cửa số WReviewOrder để đánh giá

        }
    }
}
