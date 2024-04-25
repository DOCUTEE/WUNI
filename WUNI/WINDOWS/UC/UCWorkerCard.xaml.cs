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

namespace WUNI.WINDOWS.UC
{
    /// <summary>
    /// Interaction logic for UCWorkerCard.xaml
    /// </summary>
    public partial class UCWorkerCard : UserControl
    {
        private string workerID;
        public UCWorkerCard()
        {
            InitializeComponent();
        }
        public UCWorkerCard(string workerID)
        {
            InitializeComponent();
            this.workerID = workerID;
            //Thịnh truyền thông tin thợ vào UC này 
        }
    }
}
