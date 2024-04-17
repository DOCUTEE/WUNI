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
using WUNI.WINDOWS.UC;

namespace WUNI.WINDOWS.WorkerPages
{
    /// <summary>
    /// Interaction logic for PWorkerFindJob.xaml
    /// </summary>
    public partial class PWorkerFindJob : Page
    {
        private List<Order> orders;
        public PWorkerFindJob()
        {
            InitializeComponent();
            //Đoạn code này chỉ là mẫu
            ufgOrders.Children.Add(new UCOrderCard());
            ufgOrders.Children.Add(new UCOrderCard());
            //ufgOrders.Children.Add(new UCOrderCard());
            //ufgOrders.Children.Add(new UCOrderCard());
            //ufgOrders.Children.Add(new UCOrderCard());
            //ufgOrders.Children.Add(new UCOrderCard());
            //ufgOrders.Children.Add(new UCOrderCard());
            //ufgOrders.Children.Add(new UCOrderCard());
            //ufgOrders.Children.Add(new UCOrderCard());
            //ufgOrders.Children.Add(new UCOrderCard());
            //ufgOrders.Children.Add(new UCOrderCard());
            //ufgOrders.Children.Add(new UCOrderCard());
            //ufgOrders.Children.Add(new UCOrderCard());
            //ufgOrders.Children.Add(new UCOrderCard());
            //ufgOrders.Children.Add(new UCOrderCard());
            //ufgOrders.Children.Add(new UCOrderCard());
            //ufgOrders.Children.Add(new UCOrderCard());
            
        }
        public PWorkerFindJob(List<Order> orders)
        {
            InitializeComponent();
            this.Orders = orders;
            foreach(Order order in orders)
            {
                UCOrderCard card = new UCOrderCard(order);
                ufgOrders.Children.Add(card);
            }
        }

        internal List<Order> Orders { get => orders; set => orders = value; }
    }
}
