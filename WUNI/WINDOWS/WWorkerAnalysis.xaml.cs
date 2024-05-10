using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography.Xml;
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
using WUNI.DAOClass;
using WUNI.WINDOWS.UC;

namespace WUNI.WINDOWS
{
    /// <summary>
    /// Interaction logic for WWorkerAnalysis.xaml
    /// </summary>
    public partial class WWorkerAnalysis : Window
    {
        private string workerID;
        public WWorkerAnalysis()
        {
            InitializeComponent();
        }
        public WWorkerAnalysis(string workerID)
        {
            InitializeComponent();
            this.workerID = workerID;
            ReviewDAO reviewDAO = new ReviewDAO();
            //Update rating
            float rating = reviewDAO.StarAvgOf(this.workerID);
            txbRating.Text = rating.ToString() + "⭐";
            //Update chart
            UpdateChart();
            OrderDAO orderDAO = new OrderDAO();
            WorkedDAO workedDAO = new WorkedDAO();
            List<string> orderIDs = workedDAO.GetOrderIDList(this.workerID);
            List<Order> orders = orderDAO.GetOrdersFrom(orderIDs);
            ufgOrders.Children.Clear();
            //MessageBox.Show(orders.Count.ToString());
            foreach (Order order in orders)
            {
                UCWorkedOrder uCWorkedOrder = new UCWorkedOrder(order, this.workerID);
                ufgOrders.Children.Add(uCWorkedOrder);
            }
        }
        private void UpdateChart()
        {
            //Update chart for worker
            OrderDAO orderDAO = new OrderDAO();
            int numberOrderThis = orderDAO.NumberOf(this.workerID);
            WorkerDAO workerDAO = new WorkerDAO();
            List<string> workerIDs = workerDAO.WorderIDs();
            int sum = 0, cnt = 0 ;
            foreach (string id in workerIDs)
            {
                //MessageBox.Show(id);
                int temp = orderDAO.NumberOf(id);
                if (temp != 0)
                {
                    sum += temp;
                    cnt++;
                }
            }
            double maxWidth = 950;
            //MessageBox.Show(sum.ToString());
 
            double avg = 0;
            if (numberOrderThis != 0)
            {
                avg = Math.Ceiling(sum / (double)cnt);
                double ratio = (double)numberOrderThis / avg;
                borderAVGNumber.Width = maxWidth / min(1, ratio);
                borderThisNumber.Width = maxWidth * min(1, ratio);
            }
            else
            {
                borderThisNumber.Width = 0;
            }
            if (cnt == 0) borderAVGNumber.Width = 0;
            txbOrderQuantity.Text = numberOrderThis.ToString();
            txbOrderAVGQuantity.Text = avg.ToString();
            //
            
            WorkedDAO workedDAO = new WorkedDAO();
            List<string> IDList = workedDAO.GetOrderIDList(this.workerID);
            Worker worker = workerDAO.GetWorkerFrom(workerID);
            txbSalary.Text = (worker.PricePerHour * (float)IDList.Count).ToString();
            
        }
        private double min(double a, double b)
        {
            if (a < b) return a;
            return b;
        }
    }
    
}
