using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WUNI.DAOClass;

namespace WUNI.Class
{
    internal class WorkerAccount
    {
        private string userName;
        private string passwords;
        private string workerID;

        public WorkerAccount(string userName, string passwords, string workerID)
        {
            this.userName = userName;
            this.passwords = passwords;
            this.workerID = workerID;
        }

        public string UserName { get => userName; set => userName = value; }
        public string Passwords { get => passwords; set => passwords = value; }
        public string WorkerID { get => workerID; set => workerID = value; }

       


    }
}

