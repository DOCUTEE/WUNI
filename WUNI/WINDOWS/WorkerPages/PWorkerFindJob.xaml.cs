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
using WUNI.DAOClass;
using WUNI.WINDOWS.UC;

namespace WUNI.WINDOWS.WorkerPages
{
    /// <summary>
    /// Interaction logic for PWorkerFindJob.xaml
    /// </summary>
    public partial class PWorkerFindJob : Page
    {
        private string workerID;
        public PWorkerFindJob()
        {
            InitializeComponent();
        }
        public PWorkerFindJob(string workerID)
        {
            InitializeComponent();
            this.workerID = workerID;
            ufgOrders.Children.Clear();
            OrderDAO orderDAO = new OrderDAO();
            List<Order> orders = orderDAO.GetAvailableOrder();
            foreach (Order order in orders)
            {
                UCOrderCard card = new UCOrderCard(order,this.workerID);
                ufgOrders.Children.Add(card);
            }
        }

       

        private void btnBookingMe_Click(object sender, RoutedEventArgs e)
        {
            ufgOrders.Children.Clear();
            QueueDAO queueDAO = new QueueDAO();
            List<string> orderIDs = queueDAO.GetOrderIDsOf(this.workerID);
            OrderDAO orderDAO = new OrderDAO();
            List<Order>orders = orderDAO.GetOrdersFrom(orderIDs);
            foreach (Order order in orders)
            {
                UCCardBookingMe card = new UCCardBookingMe(order,this.workerID);
                ufgOrders.Children.Add(card);
            }
        }
    }
}
