using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WUNI.Class;

namespace WUNI.DAOClass
{

    //aaaaaaaaaaaaaaaa
    internal class OrderDAO
    {
        private string tableName;
        private DBConnection conn;
        public OrderDAO()
        {
            this.tableName = "[dbo].[Order]";
            this.conn = new DBConnection();
        }
        internal string GetMaxOrderID()
        {
            DataTable da;
            string orderID;
            string sqlStr = string.Format("SELECT MAX(orderID) FROM {0}",this.tableName);
            da = this.conn.AdapterExcute(sqlStr);

            if (da.Rows.Count > 0 && da.Rows[0][0].ToString() != "")
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
            string sqlStr = string.Format("Insert into {0} (OrderID, FieldID, CustomerID, IsWorked, Description, IssueImage, IssueDate, isQueue, WorkerID)" +
                "VALUES('{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')",
                this.tableName, order.OrderID, order.FieldID, order.CustomerID, order.IsWorked, order.Description, order.IssueImage, order.IssueDate, order.IsQueue, order.WorkerID);
            this.conn.CommandExecute(sqlStr);
        }


        public List<Order> GetAvailableOrder()
        {
            List<Order> orders = new List<Order>();

            string sqlStr = string.Format("Select * from {0} Where IsWorked = 0", this.tableName);
            DataTable da = conn.AdapterExcute(sqlStr);
            foreach (DataRow row in da.Rows) 
            {
                string orderID = row["OrderID"].ToString();
                string fieldID = row["FieldID"].ToString();
                string customerID = row["CustomerID"].ToString();
                string description = row["Description"].ToString();
                string issueImage = row["IssueImage"].ToString();
                DateTime issueDate = DateTime.Parse(row["IssueDate"].ToString());
                string workerID = row["WorkerID"].ToString();
                Order order = new Order(orderID,fieldID, customerID, description, issueImage, issueDate, workerID);
                orders.Add(order);

            }
            return orders;
        }

        public List<Order> GetOrdersFrom(List<string> orderID)
        {
            List<Order> orders = new List<Order>();

            foreach(string id in orderID)
            {
                string sqlStr = string.Format("Select * from {0} Where OrderID = '{1}'", this.tableName, id);
                DataTable da =  this.conn.AdapterExcute(sqlStr);
                foreach (DataRow row in da.Rows)
                {

                    string fieldID = row["FieldID"].ToString();
                    string customerID = row["CustomerID"].ToString();
                    string description = row["Description"].ToString();
                    string issueImage = row["IssueImage"].ToString();
                    DateTime issueDate = DateTime.Parse(row["IssueDate"].ToString());
                    string workerID = row["WorkerID"].ToString();

                    Order order = new Order(id, fieldID, customerID, description, issueImage, issueDate, workerID);
                    orders.Add(order);
                }
            }
            return orders;
        }

        public List<Order> Workedfor(string customerId)
        {
            List<Order> orders = new List<Order>();
            string query = string.Format("Select * from {0} Where customerID = '{1}' and IsWorked = 1", this.tableName, customerId);
            DataTable da = this.conn.AdapterExcute(query);
            foreach (DataRow row in da.Rows)
            {
                string id = row["OrderId"].ToString();
                string fieldID = row["FieldID"].ToString();
                string customerID = row["CustomerID"].ToString();
                string description = row["Description"].ToString();
                string issueImage = row["IssueImage"].ToString();
                DateTime issueDate = DateTime.Parse(row["IssueDate"].ToString());
                string workerID = row["WorkerID"].ToString();

                Order order = new  Order(id, fieldID, customerID, description, issueImage, issueDate, workerID);
                orders.Add (order);
            }
            return orders;

        }
        public void UpdateIsWorked(string orderID)
        {
            string query = string.Format("Update {0} Set IsWorked = 1 Where OrderID = '{1}'", this.tableName, orderID);
            conn.CommandExecute(query);
        }
        public int NumberOf(string workerID)
        {
            string query = string.Format("select COUNT(*) from {0} where WorkerID = '{1}'", this.tableName, workerID);
            DataTable da = this.conn.AdapterExcute(query);
            return int.Parse(da.Rows[0][0].ToString());
        }
        
        public Order GetOrderFrom (string orderID)
        {
            
            string query = string.Format("Select * from {0} where OrderID = '{1}' ", this.tableName, orderID);
            DataTable da = this.conn.AdapterExcute(query);
                string fieldID = da.Rows[0]["FieldID"].ToString();
                string customerID = da.Rows[0]["CustomerID"].ToString();
                string description = da.Rows[0]["Description"].ToString();
                string issueImage = da.Rows[0]["IssueImage"].ToString();
                DateTime issueDate = DateTime.Parse(da.Rows[0]["IssueDate"].ToString());
                string workerID = da.Rows[0]["WorkerID"].ToString();
                Order order = new Order(orderID,
                fieldID,
                customerID,
                description,
                issueImage,
                issueDate,
                workerID
                );
                return order;
        }
        //HUYGAAAAA
    }
}
