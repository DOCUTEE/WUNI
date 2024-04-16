using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WUNI.Class
{
    internal class Liked
    {
        private string workerID;
        private string customerID;

        // Constructor
        public Liked(string workerID, string customerID)
        {
            this.workerID = workerID;
            this.customerID = customerID;
        }

        public string WorkerID { get => workerID; set => workerID = value; }
        public string CustomerID { get => customerID; set => customerID = value; }

    }
}
