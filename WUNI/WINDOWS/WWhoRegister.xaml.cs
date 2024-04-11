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
using System.Windows.Shapes;
using WUNI.WINDOWS;

namespace WUNI.WINDOWS
{
    /// <summary>
    /// Interaction logic for WWhoRegister.xaml
    /// </summary>
    public partial class WWhoRegister : Window
    {
        public WWhoRegister()
        {
            InitializeComponent();
        }
        private void btnIsWorker_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WRegisterWorker wRegisterWorker = new WRegisterWorker();
            wRegisterWorker.Show();
            this.Close();
        }

        private void btnIsCustomer_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WRegisterCustomer wRegisterCustomer = new WRegisterCustomer();
            wRegisterCustomer.Show();
            this.Close();
        }
    }
}
