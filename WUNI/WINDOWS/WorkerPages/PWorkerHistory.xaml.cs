using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Interaction logic for PWorkerHistory.xaml
    /// </summary>
    public partial class PWorkerHistory : Page
    {
        private string workerID;
        public PWorkerHistory()
        {
            InitializeComponent();
        }
        //public PWorkerHistory(string WorkerID)
        //{
        //    InitializeComponent();
        //    this.workerID = WorkerID;
        //    WorkedDAO workedDAO = new WorkedDAO();
        //    List<string> orderIDs = workedDAO.GetOrderIDList(this.workerID);
        //    OrderDAO orderDAO = new OrderDAO();
        //    List<Order>orders = orderDAO.GetOrdersFrom(orderIDs);
        //    ufgOrders.Children.Clear();
        //    MessageBox.Show(orders.Count.ToString());
        //    foreach (Order order in orders)
        //    {
        //        UCWorkedOrder uCWorkedOrder = new UCWorkedOrder(order,this.workerID);
        //        ufgOrders.Children.Add(uCWorkedOrder);
        //    }        
        //}

        //private void btnAnalysis_Click(object sender, RoutedEventArgs e)
        //{
        //    WWorkerAnalysis wWorkerAnalysis = new WWorkerAnalysis(this.workerID);
        //    wWorkerAnalysis.Show();
        //}



        public PWorkerHistory(string WorkerID)
        {
            InitializeComponent();
            this.workerID = WorkerID;
            LoadOrdersForSelectedDate(true);
        }

        private void LoadOrdersForSelectedDate(bool flag)
        {
            ufgOrders.Children.Clear();
            WorkedDAO workedDAO = new WorkedDAO();
            List<string> orderIDs = workedDAO.GetOrderIDList(this.workerID);

            DateTime selectedDate = DateTime.Today;
            if (dtpPick.SelectedDate != null)
                selectedDate = dtpPick.SelectedDate.Value;
            OrderDAO orderDAO = new OrderDAO();
            List<Order> orders = orderDAO.GetOrdersFrom(orderIDs);
            foreach (Order order in orders)
            {
                if(flag)
                {
                    UCWorkedOrder uCWorkedOrder = new UCWorkedOrder(order, this.workerID);
                    ufgOrders.Children.Add(uCWorkedOrder);
                }    
                else
                    if (order.IssueDate.Date == selectedDate)
                    {
                        UCWorkedOrder uCWorkedOrder = new UCWorkedOrder(order, this.workerID);
                        ufgOrders.Children.Add(uCWorkedOrder);
                    }
            }
        }


        private void btnAnalysis_Click(object sender, RoutedEventArgs e)
        {
            WWorkerAnalysis wWorkerAnalysis = new WWorkerAnalysis(this.workerID);
            wWorkerAnalysis.Show();
        }

        private void dtpPick_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            LoadOrdersForSelectedDate(false);
        }

        private void btnAllHistory_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            LoadOrdersForSelectedDate(true);
        }

        private void btpickTime_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
