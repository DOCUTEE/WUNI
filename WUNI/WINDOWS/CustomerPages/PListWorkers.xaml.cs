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
    /// Interaction logic for PListWorkers.xaml
    /// </summary>
    public partial class PListWorkers : Page
    {
        private Field field;
        private List<Worker> workers;
        private string customerID;
        public PListWorkers()
        {
            InitializeComponent();
        }
        public PListWorkers(Field field, string customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
            this.field = field;
            lblPageName.Content =field.FieldName;
            WorkerDAO workerDAO = new WorkerDAO();
            this.workers = workerDAO.GetListWokerOfField(field.FieldID);
            foreach (var worker in workers)
            {
                UCWorkerCard uCWorkerCard = new UCWorkerCard(worker,this.customerID);
                ufgWorkers.Children.Add(uCWorkerCard);
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


           
            var sortedWorker = this.workers;
            bool check = false ;
            if (cobSort.SelectedIndex == 1)
            {
                check = true;
                ufgWorkers.Children.Clear();
                sortedWorker = workers.OrderBy(worker => worker.PricePerHour).ToList();
            }
            else if (cobSort.SelectedIndex == 2)
            {
                check = true;
                ufgWorkers.Children.Clear();
                sortedWorker = workers.OrderByDescending(worker => worker.PricePerHour).ToList();

            }
            else if (cobSort.SelectedIndex == 3)
            {
                check = true;
                ufgWorkers.Children.Clear();
                sortedWorker = workers.OrderByDescending(worker => worker.Rating).ToList();
            }
            if (check)
            foreach (var worker in sortedWorker)
            {
                UCWorkerCard uCWorkerCard = new UCWorkerCard(worker, this.customerID);
                ufgWorkers.Children.Add(uCWorkerCard);
            }


        }
    }
}
