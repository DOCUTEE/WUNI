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

namespace WUNI.WINDOWS.UC
{
    /// <summary>
    /// Interaction logic for UCOrderCard.xaml
    /// </summary>
    public partial class UCOrderCard : UserControl
    {
        public UCOrderCard()
        {
            InitializeComponent();
            string path = Environment.CurrentDirectory;
            string path1 = Directory.GetParent(path).Parent.Parent.FullName;
            issueImage.ImageSource = new BitmapImage(new Uri(path1 + "\\Logo\\WUNI.jpg"));
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            btnConfirm.Background = (Brush)new BrushConverter().ConvertFrom("#F5F5F5");
            lblConfirm.Foreground = (Brush)new BrushConverter().ConvertFrom("#000000");
            lblConfirm.Content = "Đã nhận";
        }
    }
}
