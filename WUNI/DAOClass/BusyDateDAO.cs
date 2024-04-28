using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WUNI.Class;

namespace WUNI.DAOClass
{
    internal class BusyDateDAO
    {
        private string tableName;
        private DBConnection conn;

        public BusyDateDAO()
        {
            this.tableName = "BusyDate";
            this.conn = new DBConnection();
        }
        internal void Add(BusyDate busyDate)
        {
            string sqlStr = string.Format("Insert into {0} (WorkerID, CustomerID, BusyDate)" +
                "Values ('{1}', '{2}', '{3}')",
                this.tableName, busyDate.WorkedID, busyDate.CustomerID, busyDate.BusDate);

            this.conn.CommandExecute(sqlStr);
        }
        internal List<DateTime> GetBusyDateOf(string workerID)
        {
            string sqlStr = string.Format("Select BusyDate from {0} where WorkerID = ", this.tableName, workerID);
            DataTable data = conn.AdapterExcute(sqlStr);
            List<DateTime> busyDates = new List<DateTime>();
            foreach(DataRow row in data.Rows) 
            {
                busyDates.Add(Convert.ToDateTime(row["BusyDate"]));
            }
            return busyDates;
        }
    }
}
