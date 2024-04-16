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
using WUNI.WINDOWS.UC;

namespace WUNI.WINDOWS.WorkerPages
{
    /// <summary>
    /// Interaction logic for PWorkerFindJob.xaml
    /// </summary>
    public partial class PWorkerFindJob : Page
    {
        public PWorkerFindJob()
        {
            InitializeComponent();
            ufgOrders.Children.Add(new UCOrderCard());
            ufgOrders.Children.Add(new UCOrderCard());
            ufgOrders.Children.Add(new UCOrderCard());
            ufgOrders.Children.Add(new UCOrderCard());
            ufgOrders.Children.Add(new UCOrderCard());
            ufgOrders.Children.Add(new UCOrderCard());
            ufgOrders.Children.Add(new UCOrderCard());
            ufgOrders.Children.Add(new UCOrderCard());
            ufgOrders.Children.Add(new UCOrderCard());
        }
    }
}
