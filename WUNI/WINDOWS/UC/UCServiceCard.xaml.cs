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

namespace WUNI.WINDOWS.UC
{
    /// <summary>
    /// Interaction logic for UCServiceCard.xaml
    /// </summary>
    public partial class UCServiceCard : UserControl
    {
        private Field field;
        public UCServiceCard()
        {
            InitializeComponent();
        }
        public UCServiceCard(Field field)
        {
            InitializeComponent();
            this.field = field;
            //Thịnh gán đường dẫn ảnh imgService.source = <Đường dẫn tới Project> + \\FieldImage\\<FieldID>.png;
            //Thịnh thay lblService = tên field;
        }

        private void borderServiceCard_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void borderServiceCard_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void borderServiceCard_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
