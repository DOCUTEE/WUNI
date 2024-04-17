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

namespace WUNI.WINDOWS.WorkerPages
{
    /// <summary>
    /// Interaction logic for PBookingMe.xaml
    /// </summary>
    public partial class PBookingMe : Page
    {
        private string workerID;
        public PBookingMe()
        {
            InitializeComponent();
            
        }
        public PBookingMe(string workerID)
        {
            InitializeComponent();
            this.workerID = workerID;
            //Thịnh lấy data những đơn đang chờ add vào UniformGrid có tên là ufgOrders
        }
    }
}
