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
        public List<string> getAllService()
        {
            List<string> fields = new List<string>();
            string sqlStr = string.Format("Select Field from {0}", this.tableName);
           
            DataTable da = conn.AdapterExcute(sqlStr);
            foreach (DataRow dr in da.Rows)
            {
                string field = dr[0].ToString();
                fields.Add(field);

            }
            return fields;
        }

        public string GetFieldFrom(string id)
        {
            string query = string.Format("Select Field from {0} where FieldID = '{1}'", this.tableName, id);

            DataRow da = conn.AdapterExcute(query).Rows[0];
            return da[0].ToString();
        }
    }
}
