using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for PCustomerServices.xaml
    /// </summary>
    public partial class PCustomerServices : Page
    {
        private string customerID;
        public PCustomerServices()
        {
            InitializeComponent();
        }
        public PCustomerServices(string customerID)
        {
            //Thịnh lấy ra 1 list các Field rồi truyền vào UCServiceCard xong đem UC đưa vào uniformGrid ufgServices.
            InitializeComponent();
            
            this.customerID = customerID;

            FieldDAO fieldDAO = new FieldDAO();
            List<Field> fields = fieldDAO.GetListField();
            foreach (var field in fields)
            {
                UCServiceCard uCServiceCard = new UCServiceCard(field);
                ufgServices.Children.Add(uCServiceCard);
            }
            
        }
    }
}
