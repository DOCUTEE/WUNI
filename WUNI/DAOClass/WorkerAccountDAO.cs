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

        internal DataTable checkLogin(WorkerAccount workerAccount)
        {
            string sqlStr = string.Format("Select * from {0} where Passwords = '{1}' and UserName = '{2}'", this.tableName, workerAccount.Passwords, workerAccount.UserName);
            return conn.LoadData(sqlStr);
        }

        public void Add(WorkerAccount workerAccount)
        {
            string sqlStr = string.Format("Insert into {0} (UserName, Passwords, WorkerID)" +
                "Values ('{1}', '{2}', '{3}')", this.tableName, workerAccount.UserName, workerAccount.Passwords, workerAccount.WorkerID);

            conn.CommandExecute(sqlStr);
        }


    }
}
