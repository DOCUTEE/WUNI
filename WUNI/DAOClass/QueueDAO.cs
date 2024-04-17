using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using WUNI.Class;

namespace WUNI.DAOClass
{
    internal class QueueDAO
    {
        private string tableName;
        private DBConnection conn;
        public QueueDAO()
        {
            this.tableName = "Queuee";
            this.conn = new DBConnection();
        }
        internal void Add(Queuee queuee)
        {
            string sqlStr = string.Format("Insert into {0} (WorkerID, OrderID" +
                "Values ('{1}', '{2}'",
                this.tableName, queuee.WorkerID, queuee.OrderID);
            conn.CommandExecute(sqlStr);
        }

        internal void RemoveOrder(Queuee queuee)
        {
            string sqlStr = string.Format("DELETE FROM {0} WHERE WorkerID = '{1}' and OrderID = '{2}'",
                this.tableName, queuee.WorkerID, queuee.OrderID);
            this.conn.CommandExecute(sqlStr);
        }

        List<string> GetOrderIDsOf(string workerID)
        {
            List<string> orderIDs = new List<string>();
            string sqlStr = string.Format("select * From {0} where WorkerID = '{1}'", this.tableName, workerID);
            DataTable da = this.conn.AdapterExcute(sqlStr);
            
            foreach(DataRow row in da.Rows)
            {
                string orderID = row["OrderID"].ToString();
                orderIDs.Add(orderID);
            }
            return orderIDs;
        }
    }
}
