using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WUNI.Class;

namespace WUNI.DAOClass
{
    internal class CustomerAccountDAO
    {
        private string tableName;
        private DBConnection conn;

        public CustomerAccountDAO()
        {
            this.tableName = "CustomerAccount";
            this.conn = new DBConnection();
        }
        internal bool checkLogin(CustomerAccount customerAccount)
        {
            string sqlStr = string.Format("Select * from {0} where UserName = '{1}' and Passwords = '{2}'", this.tableName, customerAccount.UserName, customerAccount.Passwords);
            DataTable da = this.conn.AdapterExcute(sqlStr);
            return da.Rows.Count > 0;
        }


        public void Add(CustomerAccount customerAccount)
        {
            string sqlStr = string.Format("Insert into {0} (UserName, Passwords, CustomerID)" +
                "Values ('{1}', '{2}', '{3}')", this.tableName, customerAccount.UserName, customerAccount.Passwords, customerAccount.CustomerID);

            conn.CommandExecute(sqlStr);
        }

        public string GetCustomerID(CustomerAccount customerAccount)
        {
            string sqlStr = string.Format("Select WorkerID from {0} where UserName = '{1}'", this.tableName, customerAccount.UserName);
            DataTable da = this.conn.AdapterExcute(sqlStr);
            return da.Rows[0][0].ToString();
        }
    }
}
