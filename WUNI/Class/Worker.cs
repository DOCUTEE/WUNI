using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using WUNI.DAOClass;

namespace WUNI.Class
{
    internal class Worker
    {
        private string workerID;
        private string citizenID;
        private string name;
        private DateTime birth;
        private string gender;
        private string address;
        private string mail;
        private string phoneNumber;
        private string pricePerHour;
        private string fieldID;
        private string description;
        private float rating;
        private string profileImage;


        public Worker(string citizenID, string name, DateTime birth, string gender, string address, string mail, string phoneNumber, string pricePerHour, string fieldID, string description, float rating, string profileImage)
        {
            this.workerID = getLastWorkerID();
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
            this.profileImage = profileImage;
        }

        private string getLastWorkerID()
        {
            WorkerDAO workerDAO= new WorkerDAO();
            return workerDAO.getLastWorkerID();

        }
  
        public string WorkerID { get => workerID; set => workerID = value; }
        public string CitizenID { get => citizenID; set => citizenID = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Birth { get => birth; set => birth = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Address { get => address; set => address = value; }
        public string Mail { get => mail; set => mail = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string PricePerHour { get => pricePerHour; set => pricePerHour = value; }
        public string FieldID { get => fieldID; set => fieldID = value; }
        public string Description { get => description; set => description = value; }
        public float Rating { get => rating; set => rating = value; }
        public string ProfileImage { get => profileImage; set => profileImage = value; }
    }
}
