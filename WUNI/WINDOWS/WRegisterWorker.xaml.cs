using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace WUNI.WINDOWS
{
    /// <summary>
    /// Interaction logic for WRegisterWorker.xaml
    /// </summary>
    public partial class WRegisterWorker : Window
    {
        public WRegisterWorker()
        {
            InitializeComponent();

        }
        public void SelectImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                // Tạo một BitmapImage
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(openFileDialog.FileName);
                bitmap.EndInit();

                // Đặt ảnh cho Image control
                imgProfile.Source = bitmap;
            }
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            //Thịnh viết code bắt đầu từ đây để khi bấm đăng ký thì thông tin thợ và account thợ sẽ lần lượt được add vào bảng Worker và WorkerAccount 
        }
    }
}
