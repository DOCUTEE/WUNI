using System;
using System.Collections.Generic;
using System.Linq;
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
        private DateOnly issueDate;
        private bool isQueue;
        private string workerID;

        public Order(string fieldID, string customerID, string description, string issueImage, DateOnly issueDate, string workerID)
        {
            this.orderID = getLastOrderID();
            this.fieldID = fieldID;
            this.customerID = customerID;
            this.isWorked = false;
            this.description = description;
            this.issueImage = issueImage;
            this.issueDate = issueDate;
            this.isQueue = false;
            this.workerID = workerID;
        }

        public string GetFieldFrom(string fieldID)
        {
            FieldDAO fieldDAO= new FieldDAO();
            return fieldDAO.GetFieldFrom(fieldID);
        }

        public string GetAddressFrom(string  customerID)
        {
            CustomerDAO customerDAO= new CustomerDAO();
            Customer customer = customerDAO.GetCustomerFrom(customerID);
            return customer.Address;

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
        public DateOnly IssueDate { get => issueDate; set => issueDate = value; }
        public bool IsQueue { get => isQueue; set => isQueue = value; }

        public string WorkerID { get => workerID; set => workerID = value; }
    }
}
