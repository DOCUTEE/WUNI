using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using WUNI.Class;

namespace WUNI.DAOClass
{
    internal class WorkerDAO
    {
        private string tableName;
        private DBConnection conn;
        public WorkerDAO()
        {
            this.tableName = "Worker";
            this.conn = new DBConnection();
        }
        public void Add(Worker worker)
        {
            string sqlStr = string.Format("INSERT INTO {0} (WorkerID, CitizenID, Name, Birth, Gender, Address, Mail, PhoneNumber, PricePerHour, FieldID, Description, Rating, ProfileImage)" +
                    " VALUES('{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}', '{11}','{12}','{13}')",
                    this.tableName, worker.WorkerID, worker.CitizenID, worker.Name, worker.Birth, worker.Gender,
                    worker.Address, worker.Mail, worker.PhoneNumber, worker.PricePerHour, worker.FieldID, worker.Description, 0.0, worker.ProfileImage);
            this.conn.CommandExecute(sqlStr);


        }


        internal string getLastWorkerID()
        {
            DataTable da;
            string workerID;
            string sqlStr = string.Format("SELECT MAX(WorkerID) FROM Worker");
            da = this.conn.LoadData(sqlStr);

            if (da.Rows.Count > 0)
            {
                workerID = da.Rows[0][0].ToString();
                int num= int.Parse(workerID);
                num++;
                workerID = num.ToString();
            }
            else
            {
                workerID = "1";
            }
            return workerID;
        }


    }
}
