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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WUNI.Class;
using WUNI.WINDOWS.CustomerPages;

namespace WUNI.WINDOWS.UC
{
    /// <summary>
    /// Interaction logic for UCServiceCard.xaml
    /// </summary>
    public partial class UCServiceCard : UserControl
    {
        private Field field;
        private string customerID;
        public UCServiceCard()
        {
            InitializeComponent();
        }
        public UCServiceCard(Field field, string customerID)
        {
            InitializeComponent();
            string path = Environment.CurrentDirectory;
            string path1 = Directory.GetParent(path).Parent.Parent.FullName;
            this.field = field;
            imgService.ImageSource = new BitmapImage(new Uri(path1 + "\\FieldImage\\" + field.FieldID.ToString() + ".png", UriKind.Relative)); ;
            lblService.Content = field.FieldName;
            this.customerID = customerID;
            //Thịnh gán đường dẫn ảnh imgService.source = <Đường dẫn tới Project> + \\FieldImage\\<FieldID>.png;
            //Thịnh thay lblService = tên field;
        }

        private void borderServiceCard_MouseEnter(object sender, MouseEventArgs e)
        {
            borderServiceCard.BorderThickness = new Thickness(3);
            borderServiceCard.BorderBrush = (SolidColorBrush)new BrushConverter().ConvertFrom("#002B5B");

        }

        private void borderServiceCard_MouseLeave(object sender, MouseEventArgs e)
        {
            borderServiceCard.BorderThickness = new Thickness(0);
            //borderServiceCard.BorderBrush = (SolidColorBrush)new BrushConverter().ConvertFrom("#00000000");
        }
    

        private void borderServiceCard_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WCustomerMain wCustomerMain = (WCustomerMain)Window.GetWindow(this);
            wCustomerMain.fContent.NavigationService.Navigate(new PListWorkers(this.field,this.customerID));
        }

        
    }
}
