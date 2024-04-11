using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WUNI.DAOClass;

namespace WUNI.Class
{
    internal class Worked
    {
        private string orderID;
        private string workerID;

        public Worked(string orderID, string workerID)
        {
            this.orderID = orderID;
            this.workerID = workerID;
        }

     
        public string OrderID { get => orderID; set => orderID = value; }
        public string WorkerID { get => workerID; set => workerID = value; }
    }
}
