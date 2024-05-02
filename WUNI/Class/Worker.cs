using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using WUNI.DAOClass;

namespace WUNI.Class
{
    public class Worker
    {
        private string workerID;
        private string citizenID;
        private string name;
        private DateTime birth;
        private string gender;
        private string address;
        private string mail;
        private string phoneNumber;
        private float pricePerHour;
        private string fieldID;
        private string description;
        private float rating;
        private string profileImage;


        public Worker(string citizenID, string name, DateTime birth, string gender, string address, string mail, string phoneNumber, float pricePerHour, string fieldID, string description, float rating, string profileImage)
        {
            Init(getLastWorkerID(), citizenID, name, birth, gender, address, mail, phoneNumber, pricePerHour, fieldID, description, rating, profileImage);
        }

        public Worker(string workerID, string citizenID, string name, DateTime birth, string gender, string address, string mail, string phoneNumber, float pricePerHour, string fieldID, string description, float rating, string profileImage)
        {
            Init(workerID, citizenID, name, birth, gender, address, mail, phoneNumber, pricePerHour, fieldID, description, rating, profileImage);
        }
        private void Init(string workerID, string citizenID, string name, DateTime birth, string gender, string address, string mail, string phoneNumber, float pricePerHour, string fieldID, string description, float rating, string profileImage)
        {
            this.workerID = workerID;
            this.citizenID = citizenID;
            this.name = name;
            this.birth = birth;
            this.gender = gender;
            this.address = address;
            this.mail = mail;
            this.phoneNumber = phoneNumber;
            this.pricePerHour = pricePerHour;
            this.fieldID = fieldID;
            this.description = description;
            this.rating = rating;
            this.profileImage = String.Format("\\WorkerImage\\{0}.png", this.WorkerID);
        }



        public bool IsInputNotEmpty()
        {
            return
                   !string.IsNullOrWhiteSpace(citizenID) &&
                   !string.IsNullOrWhiteSpace(name) &&
                   birth != DateTime.MinValue &&
                   !string.IsNullOrWhiteSpace(gender) &&
                   !string.IsNullOrWhiteSpace(address) &&
                   !string.IsNullOrWhiteSpace(mail) &&
                   !string.IsNullOrWhiteSpace(phoneNumber) &&
                   pricePerHour > 0 &&
                   !string.IsNullOrWhiteSpace(fieldID) &&
                   !string.IsNullOrWhiteSpace(description) &&
                   rating >= 0 &&
                   !string.IsNullOrWhiteSpace(profileImage) &&
                   this.fieldID != "0" && this.pricePerHour >= 0 && this.gender != "Giới tính";
        }

        public bool IsMailValid()
        {
            string m = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            Regex r = new Regex(m);
            return r.IsMatch(mail);
        }

        public bool IsValidAge()
        {
            return ((DateTime.Now.Year - birth.Year) >= 18);

        }

        public bool IsValidPhone()
        {
            string m = @"^\d{3}-\d{4}-\d{3}$";
            Regex r = new Regex(m);
            return r.IsMatch(phoneNumber);
        }
        private string getLastWorkerID()
        {
            WorkerDAO workerDAO = new WorkerDAO();
            return workerDAO.getLastWorkerID();

        }

        public bool CheckInput()
        {
            bool flag = true;
            if (!IsInputNotEmpty())
            {
                flag = false;
                MessageBox.Show("Tồn tại ô chưa điền");
            }
            else if (!IsMailValid())
            {
                flag = false;
                MessageBox.Show("Email không phù hợp");
            }
            else if (!IsValidAge())
            {
                MessageBox.Show("Người dùng phải lớn hơn 17 tuổi");
                flag = false;
            }
            else if (!IsValidPhone())
            {
                flag = false;
                MessageBox.Show("Số điện thoại không hợp lệ");
            }
            return flag;
        }

        public string WorkerID { get => workerID; set => workerID = value; }
        public string CitizenID { get => citizenID; set => citizenID = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Birth { get => birth; set => birth = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Address { get => address; set => address = value; }
        public string Mail { get => mail; set => mail = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public float PricePerHour { get => pricePerHour; set => pricePerHour = value; }
        public string FieldID { get => fieldID; set => fieldID = value; }
        public string Description { get => description; set => description = value; }
        public float Rating { get => rating; set => rating = value; }
        public string ProfileImage { get => profileImage; set => profileImage = value; }
    }

    //public bool Authentication(Worker worker)
    //{
       
    //}
}
