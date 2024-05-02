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

namespace WUNI.WINDOWS.CustomerPages
{
    /// <summary>
    /// Interaction logic for PCustomerHistory.xaml
    /// </summary>
    public partial class PCustomerHistory : Page
    {
        private string customerID;
        public PCustomerHistory()
        {
            InitializeComponent();
        }
        public PCustomerHistory(string customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
            //Task: Truyền UCCustomerReviewOrder vào ufgWorkedOrders
            WorkedDAO workedDAO = new WorkedDAO();
            foreach (Order order in workedDAO.WorkedFor(this.customerID))
            {
                UCCustomerReviewOrder uCCustomerReviewOrder = new UCCustomerReviewOrder(order);
                ufgWorkedOrders.Children.Add(uCCustomerReviewOrder);
            }


        }

    }
}
