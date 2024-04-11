using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WUNI.DAOClass
{
    internal class FieldDAO
    {
        private string tableName;
        private DBConnection conn;
        public FieldDAO()
        {
            this.tableName = "Field";
            this.conn = new DBConnection();
        }
        public DataTable getAllService()
        {
            string sqlStr = string.Format("Select FieldID, Field from {0}", this.tableName);
           
            DataTable da = conn.LoadData(sqlStr);
            return da;
        }
    }
}
