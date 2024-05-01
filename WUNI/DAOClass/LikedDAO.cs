using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using WUNI.Class;

namespace WUNI.DAOClass
{
    internal class LikedDAO
    {
        private string tableName;
        private DBConnection conn;
        public LikedDAO()
        {
            this.tableName = "Liked";
            this.conn = new DBConnection();
        }
        

        public void Add(Liked liked)
        {
            string sqlStr = string.Format("Insert into {0} (WorkerID, CustomerID)" +
               "VALUES('{1}', '{2}'",
               this.tableName, liked.WorkerID, liked.CustomerID);
            this.conn.CommandExecute(sqlStr);
        }

        public void Remove(Liked liked)
        {
            string query = string.Format("DELETE FROM {0} WHERE WorkerID = '{1}' and CustomerID = '{2}'",
               this.tableName, liked.WorkerID, liked.CustomerID);
            this.conn.CommandExecute(query);
        }

        public List<Worker> ListLikedOf(string customerID)
        {
            List<Worker> workers = new List<Worker>();

            string query = string.Format("Select WorkerID from {0} Where CustomerID = '{1}'", this.tableName, customerID);
            DataTable da = conn.AdapterExcute(query);
            foreach (DataRow row in da.Rows)
            {
                string workerID = row[0].ToString();

                WorkerDAO workerDAO = new WorkerDAO();
                Worker worker = workerDAO.GetWorkerFrom(workerID);
                workers.Add(worker);

            }
            return workers;
        }
        //public bool isLiked(string  customerID, string workerID)
        //{
        //    string query = string.Format("Select * from ")
        //}
    }
}
