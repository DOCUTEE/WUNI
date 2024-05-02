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
    /// Interaction logic for PWorkerHistory.xaml
    /// </summary>
    public partial class PWorkerHistory : Page
    {
        private string workerID;
        public PWorkerHistory()
        {
            InitializeComponent();
        }
        public PWorkerHistory(string WorkerID)
        {
            InitializeComponent();
            this.workerID = WorkerID;
            WorkedDAO workedDAO = new WorkedDAO();
            List<string> orderIDs = workedDAO.GetOrderIDList(this.workerID);
            OrderDAO orderDAO = new OrderDAO();
            List<Order>orders = orderDAO.GetOrdersFrom(orderIDs);
            ufgOrders.Children.Clear();
            MessageBox.Show(orders.Count.ToString());
            foreach (Order order in orders)
            {
                UCWorkedOrder uCWorkedOrder = new UCWorkedOrder(order,this.workerID);
                ufgOrders.Children.Add(uCWorkedOrder);
            }        
        }

        private void btnAnalysis_Click(object sender, RoutedEventArgs e)
        {
            WWorkerAnalysis wWorkerAnalysis = new WWorkerAnalysis(this.workerID);
            wWorkerAnalysis.Show();
        }
    }
}
