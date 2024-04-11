using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WUNI.Class;

namespace WUNI.DAOClass
{
    internal class OrderDAO
    {
        private string tableName;
        private DBConnection conn;
        public OrderDAO()
        {
            this.tableName = "Orders";
            this.conn = new DBConnection();
        }
        internal string getLastOrderID()
        {
            DataTable da;
            string orderID;
            string sqlStr = string.Format("SELECT MAX(orderID) FROM Orders");
            da = this.conn.LoadData(sqlStr);

            if (da.Rows.Count > 0)
            {
                orderID = da.Rows[0][0].ToString();
                int num = int.Parse(orderID);
                num++;
                orderID = num.ToString();
            }
            else
            {
                orderID = "1";
            }
            return orderID;
        }


        public void Add(Order order)
{
            string sqlStr = string.Format("Insert into {0} (OrderID, FieldID, CustomerID, IsWorked, Description, IssueImage, IssueDate, isQueue, WorkerID" +
                "VALUES('{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}'",
                this.tableName, order.OrderID, order.FieldID, order.CustomerID, order.IsWorked, order.Description, order.IssueImage, order.IssueDate, order.IsQueue, order.WorkerID);
            this.conn.CommandExecute(sqlStr);
        }

    }
}
