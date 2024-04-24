using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WUNI.Class;
using WUNI.DAOClass;

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
            FieldDAO fieldDAO = new FieldDAO();
            List<string>services = fieldDAO.getAllService();
            foreach(string service in services)
            {
                cboField.Items.Add(service);
                //MessageBox.Show(service);
            }
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
            //Add worker information into Worker Table
            Worker worker = new Worker(
                txbCitizenID.Text,
                txbName.Text,
                dtpBirth.SelectedDate.Value,
                cboGender.Text,
                txbAddress.Text,
                txbEmail.Text,
                txbPhoneNumber.Text,
                float.Parse(txbPricePerHour.Text),
                cboField.SelectedIndex.ToString(),
                txbDescription.Text,
                5,
                "HUYGA"
            );
            WorkerDAO workerDAO = new WorkerDAO();
            workerDAO.Add( worker );
            
            //Copy and  paste image of the worker into WorkerImage Folder
            BitmapImage bitmapImage = imgProfile.Source as BitmapImage;
            string originalPath = bitmapImage.UriSource.LocalPath;
            string path = Environment.CurrentDirectory;
            string targetPath = Directory.GetParent(path).Parent.Parent.FullName;
            MessageBox.Show(targetPath);
            //Create ID for this image
            string imageID = worker.ProfileImage;
            string destFile = targetPath + imageID;
            System.IO.File.Copy(originalPath, destFile, true);
            WorkerAccount workerAccount = new WorkerAccount(
                txbUserName.Text,
                txpPassword.Password.ToString(),
                worker.WorkerID
            );
            WorkerAccountDAO workerAccountDAO = new WorkerAccountDAO();
            workerAccountDAO.Add(workerAccount);
            this.Close();
        }
    }
}
