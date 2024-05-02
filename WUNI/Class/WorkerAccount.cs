using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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

        public bool IsUniqueUserName()
        {
            WorkerAccountDAO workerAccountDAO = new WorkerAccountDAO();

            if(!workerAccountDAO.IsUniqueUserName(userName))
            {
                MessageBox.Show("Tên đăng nhập đã được sử dụng");
                return false;
            }
            return true;

        }

        public bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(userName) ||
                   string.IsNullOrWhiteSpace(passwords))
            {
                MessageBox.Show("Chưa nhập tên đăng nhập hoặc mật khẩu");
                return false;
            }
            return true;
        }

    }
}

