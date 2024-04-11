using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

      
    }
}
