using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WUNI.DAOClass;

namespace WUNI.Class
{
    internal class Customer
    {
        private string customerID;
        private string citizenID;
        private string name;
        private DateTime birth;
        private string gender;
        private string address;
        private string mail;
        private string phoneNumber;
        private string description;
        private string profileImage;

        public Customer(string citizenID, string name, DateTime birth, string gender, string address, string mail, string phoneNumber, string description, string profileImage)
        {
           Init(getLastCustomerID(), citizenID, name, birth , gender, address, mail, phoneNumber, description, profileImage);
           
        }
        public Customer(string customerID, string citizenID, string name, DateTime birth, string gender, string address, string mail, string phoneNumber, string description, string profileImage)
        {
            Init(customerID, citizenID, name, birth , gender,address, mail, phoneNumber, description,profileImage);

        }


        private void Init(string customerID, string citizenID, string name, DateTime birth, string gender, string address, string mail, string phoneNumber, string description, string profileImage)
        {
            this.customerID = customerID;
            this.citizenID = citizenID;
            this.name = name;
            this.birth = birth;
            this.gender = gender;
            this.address = address;
            this.mail = mail;
            this.phoneNumber = phoneNumber;
            this.description = description;
            this.profileImage = profileImage;

        }
        private string getLastCustomerID()
        {
            CustomerDAO customerDAO = new CustomerDAO();
            return customerDAO.getLastCustomerID();

        }   
        public string CustomerID { get => customerID; set => customerID = value; }
        public string CitizenID { get => citizenID; set => citizenID = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Birth { get => birth; set => birth = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Address { get => address; set => address = value; }
        public string Mail { get => mail; set => mail = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Description { get => description; set => description = value; }
        public string ProfileImage { get => profileImage; set => profileImage = value; }
    }

}
