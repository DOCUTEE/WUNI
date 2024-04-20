using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WUNI.DAOClass;

namespace WUNI.Class
{
    internal class Queuee
    {
        private string workerID;
        private string orderID;

        public Queuee(string workerID, string orderID)
        {
            this.workerID = workerID;
            this.orderID = orderID;
            Add();
        }

        public string WorkerID { get => workerID; set => workerID = value; }
        public string OrderID { get => orderID; set => orderID = value; }

        public void Add()
        {
            QueueDAO queueDAO = new QueueDAO();
            queueDAO.Add(this);
        }

        public void RemoveOrder()
        {
            QueueDAO queueDAO = new QueueDAO();
            queueDAO.RemoveOrder(this);
        }

       
    }
}
