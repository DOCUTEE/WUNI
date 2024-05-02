using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WUNI.DAOClass;

namespace WUNI.Class
{
    public class Order
    {
        private string orderID;
        private string fieldID;
        private string customerID;
        private bool isWorked;
        private string description;
        private string issueImage;
        private DateTime issueDate;
        private bool isQueue;
        private string workerID;
        public Order ()
        {

        }

        public Order(string fieldID, string customerID, string description, string issueImage, DateTime issueDate, string workerID)
        {
            Init(getLastOrderID(), fieldID, customerID, description, issueDate, workerID);


        }
        public Order(string orderID, string fieldID, string customerID, string description, string issueImage, DateTime issueDate, string workerID)
        {
            Init(orderID, fieldID, customerID, description, issueDate, workerID);


        }

        

        void Init(string orderID, string fieldID, string customerID, string description, DateTime issueDate, string workerID)
        {
            this.orderID = orderID;
            this.fieldID = fieldID;
            this.customerID = customerID;
            this.isWorked = false;
            this.description = description;
            this.issueImage = "\\IssueImage\\"+ orderID.ToString() + ".png";
            this.issueDate = issueDate;
            this.isQueue = false;
            this.workerID = workerID;
        }

        public string GetFieldName()
        {
            FieldDAO fieldDAO= new FieldDAO();
            return fieldDAO.GetFieldFrom(this.fieldID);
        }

        public string GetAddress()
        {
            CustomerDAO customerDAO= new CustomerDAO();
            Customer customer = customerDAO.GetCustomerFrom(this.customerID);
            return customer.Address;
        }
        public string GetCustomerName()
        {
            CustomerDAO customerDAO= new CustomerDAO();
            Customer customer = customerDAO.GetCustomerFrom(this.customerID);
            return customer.Name;
        }
        public string GetPhoneNumber()
        {
            CustomerDAO customerDAO= new CustomerDAO();
            Customer customer = customerDAO.GetCustomerFrom(this.customerID);
            return customer.PhoneNumber;
        }
        private string getLastOrderID()
        {
            OrderDAO orderDAO = new OrderDAO();
            return orderDAO.GetMaxOrderID();

        }

        public string OrderID { get => orderID; set => orderID = value; }
        public string FieldID { get => fieldID; set => fieldID = value; }
        public string CustomerID { get => customerID; set => customerID = value; }
        public bool IsWorked { get => isWorked; set => isWorked = value; }
        public string Description { get => description; set => description = value; }
        public string IssueImage { get => issueImage; set => issueImage = value; }
        public DateTime IssueDate { get => issueDate; set => issueDate = value; }
        public bool IsQueue { get => isQueue; set => isQueue = value; }

        public string WorkerID { get => workerID; set => workerID = value; }
    }
}
