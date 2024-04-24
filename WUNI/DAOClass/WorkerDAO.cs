using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Xml.Linq;
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
            da = this.conn.AdapterExcute(sqlStr);

            if (da.Rows.Count > 0)
            {
                workerID = da.Rows[0][0].ToString();
                MessageBox.Show(workerID);
                int num;
                if (workerID != "") num = int.Parse(workerID);
                else num = 1;
                num++;
                workerID = num.ToString();
            }
            else
            {
                workerID = "1";
            }
            return workerID;
        }


        public List<Worker> ListWorkerIs(string fieldID)
        {
            List<Worker> workers = new List<Worker>();
            string query = string.Format("select * from {0} where FieldID = '{1}'", this.tableName, fieldID);
            DataTable da = this.conn.AdapterExcute(query);
            foreach (DataRow workerRow in da.Rows)
            {

                string workerID = workerRow[0].ToString();
                string citizenID = workerRow[1].ToString();
                string name = workerRow[2].ToString();
                DateTime birth = DateTime.Parse(workerRow[3].ToString());
                string gender = workerRow[4].ToString();
                string address = workerRow[5].ToString();
                string mail = workerRow[6].ToString();
                string phoneNumber = workerRow[7].ToString();
                float pricePerHour = float.Parse(workerRow[8].ToString());
                string field = workerID[9].ToString();
                string description = workerRow[10].ToString();
                float rating = float.Parse(workerRow[11].ToString());
                string profileImage = workerRow[12].ToString();

                Worker worker = new Worker(workerID, citizenID, name,
                    birth, gender, address, mail, phoneNumber, pricePerHour,
                    field, description, rating, profileImage);
                workers.Add(worker);

            }
            return workers;
        }

        public Worker GetWorkerFrom(string workerID)
        {
            Worker worker = null;
            string query = string.Format("select * from {0} where WorkerID = '{1}'", this.tableName, workerID);
            DataTable da = this.conn.AdapterExcute(query);
            foreach (DataRow workerRow in da.Rows)
            {

                string id = workerRow[0].ToString();
                string citizenID = workerRow[1].ToString();
                string name = workerRow[2].ToString();
                DateTime birth = DateTime.Parse(workerRow[3].ToString());
                string gender = workerRow[4].ToString();
                string address = workerRow[5].ToString();
                string mail = workerRow[6].ToString();
                string phoneNumber = workerRow[7].ToString();
                float pricePerHour = float.Parse(workerRow[8].ToString());
                string field = workerID[9].ToString();
                string description = workerRow[10].ToString();
                float rating = float.Parse(workerRow[11].ToString());
                string profileImage = workerRow[12].ToString();

                worker = new Worker(workerID, citizenID, name,
                    birth, gender, address, mail, phoneNumber, pricePerHour,
                    field, description, rating, profileImage);
            }
            return worker;
        }
        public List<string> WorderIDs()
        {
            string query = string.Format("Select WorkerID from {0}",this.tableName);
            DataTable da = this.conn.AdapterExcute(query);
            List<string> IDs = new List<string>();
            foreach(DataRow row in da.Rows)
            {
                IDs.Add(row[0].ToString());
            }
            return IDs;
        }
    }
}
