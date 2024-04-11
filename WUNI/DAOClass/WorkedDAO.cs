
using System;
using System.Collections.Generic;
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
    }
}
