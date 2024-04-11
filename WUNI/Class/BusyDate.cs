using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WUNI.DAOClass;

namespace WUNI.Class
{
    internal class BusyDate
    {
        private string workedID;
        private string customerID;
        private DateOnly busDate;

        public BusyDate(string workedID, string customerID, DateOnly busDate)
        {
            this.workedID = workedID;
            this.customerID = customerID;
            this.busDate = busDate;
            Add();
        }
        public void Add()
        {
            BusyDateDAO busyDateDAO = new BusyDateDAO();
            busyDateDAO.Add(this);
        }
        



        public string WorkedID { get => workedID; set => workedID = value; }
        public string CustomerID { get => customerID; set => customerID = value; }
        public DateOnly BusDate { get => busDate; set => busDate = value; }
    }


}