using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using WUNI.Class;

namespace WUNI.DAOClass
{
    internal class CustomerDAO
    {
        private string tableName;
        private DBConnection conn;
        public CustomerDAO()
        {
            this.tableName = "Customer";
            this.conn = new DBConnection();
        }
        public void Add(Customer customer)
        {
            string sqlStr = string.Format("INSERT INTO {0} (CustomerID, CitizenID, Name, Birth, Gender, Address, Mail, PhoneNumber, Description, ProfileImage)" +
                    " VALUES('{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
            this.tableName, customer.CustomerID, customer.CitizenID, customer.Name, customer.Birth, customer.Gender,
                    customer.Address, customer.Mail, customer.PhoneNumber, customer.Description, customer.ProfileImage);
            this.conn.CommandExecute(sqlStr);
        }

        internal string getLastCustomerID()
        {
            DataTable da;
            string customerID;
            string sqlStr = string.Format("SELECT MAX(CustomerID) FROM Customer");
            da = this.conn.AdapterExcute(sqlStr);

            if (da.Rows.Count > 0)
            {
                customerID = da.Rows[0][0].ToString();
                int num = int.Parse(customerID);
                num++;
                customerID = num.ToString();
            }
            else
            {
                customerID = "1";
            }
            return customerID;
        }
    }
}
