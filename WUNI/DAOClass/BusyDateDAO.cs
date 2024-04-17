using System;
using System.Collections.Generic;
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
                "Values ('{1}', '{2}', '{3}'",
                this.tableName, busyDate.WorkedID, busyDate.CustomerID, busyDate.BusDate);

            this.conn.CommandExecute(sqlStr);
        }
    }
}
