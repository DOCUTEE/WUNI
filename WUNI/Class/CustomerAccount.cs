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
    internal class CustomerAccount
    {
        private string userName;
        private string passwords;
        private string customerID;

        public CustomerAccount(string userName, string passwords, string customerID)
        {
            this.userName = userName;
            this.passwords = passwords;
            this.customerID = customerID;
        }

        public string UserName { get => userName; set => userName = value; }
        public string Passwords { get => passwords; set => passwords = value; }
        public string CustomerID { get => customerID; set => customerID = value; }


        public bool IsUniqueUserName()
        {
            CustomerAccountDAO customerAccountDAO = new CustomerAccountDAO();

            if (!customerAccountDAO.IsUniqueUserName(userName))
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
