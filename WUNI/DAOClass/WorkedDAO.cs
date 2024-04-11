
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using WUNI.Class;

namespace WUNI.DAOClass
{
    internal class WorkedDAO
    {
        private string tableName;
        private DBConnection conn;
        public WorkedDAO()
        {
            this.tableName = "Worked";
            this.conn = new DBConnection();
        }
        internal void Add(Worked worked)
        {
            string sqlStr = string.Format("Insert into  {0} (OrderID, WorkerID)" +
                "Values('{1}', '{2}')", this.tableName, worked.OrderID, worked.WorkerID);

            this.conn.CommandExecute(sqlStr);
        }


        public List<string> GetOrderIDList(string workerID)
        {
            List<string> orderIDs = new List<string>();
            string sqlStr = string.Format("Select OrderID from {0} Where WorkerID = '{1}'", this.tableName, workerID);
            DataTable da = this.conn.AdapterExcute(sqlStr);
            foreach (DataRow row in da.Rows)
            {
                string orderID = row[0].ToString();
                orderIDs.Add(orderID);
            }
            return orderIDs;
        }

        public int NumberWorkedOF(string workerID)
        {
            string query = string.Format("SELECT COUNT(*) FROM {0} WHERE WorkerID = '{1}'", this.tableName, workerID);
            DataTable da = this.conn.AdapterExcute(query);
            return int.Parse(da.Rows[0].ToString());

        }

        //public List<Order> WorkedFor(string customerID)
        //Phần này phải nằm trong OrderDAO vì không có thuộc tính customerID trong Worked. 
        //tìm trong Order where customerID= id and isWorked = 1
        
    }
}

