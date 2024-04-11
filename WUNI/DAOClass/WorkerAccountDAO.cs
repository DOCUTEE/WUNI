using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WUNI.Class;

namespace WUNI.DAOClass
{
    internal class WorkerAccountDAO
    {
        private string tableName;
        private DBConnection conn;
        public WorkerAccountDAO()
        {
            this.tableName = "WorkerAccount";
            this.conn = new DBConnection();
        }
       
        internal bool checkLogin(WorkerAccount workerAccount)
        {
            string sqlStr = string.Format("Select * from {0} where Passwords = '{1}' and UserName = '{2}'", this.tableName, workerAccount.Passwords, workerAccount.UserName);
            DataTable da = conn.AdapterExcute(sqlStr);
            return da.Rows.Count > 0;

        }

        public void Add(WorkerAccount workerAccount)
        {
            string sqlStr = string.Format("Insert into {0} (UserName, Passwords, WorkerID)" +
                "Values ('{1}', '{2}', '{3}')", this.tableName, workerAccount.UserName, workerAccount.Passwords, workerAccount.WorkerID);

            conn.CommandExecute(sqlStr);
        }

        public string GetWorkerID(WorkerAccount workerAccount)
        { 
            string sqlStr = string.Format("Select WorkerID from {0} where UserName = '{1}'", this.tableName, workerAccount.UserName);
            DataTable da = this.conn.AdapterExcute(sqlStr);
            return da.Rows[0][0].ToString();
        }

    }
}
