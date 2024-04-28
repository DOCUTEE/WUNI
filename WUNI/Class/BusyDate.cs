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
        private DateTime busDate;

        public BusyDate(string workedID, string customerID, DateTime busDate)
        {
            this.workedID = workedID;
            this.customerID = customerID;
            this.busDate = busDate;
        }
        


        public string WorkedID { get => workedID; set => workedID = value; }
        public string CustomerID { get => customerID; set => customerID = value; }
        public DateTime BusDate { get => busDate; set => busDate = value; }
    }


}