using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;
using WUNI.Properties;
using System.Data;
namespace WUNI
{
    internal class DBConnection
    {

        SqlConnection conn;
        public DBConnection()
        {
            conn = new SqlConnection(Properties.Settings.Default.connStr);
        }

        public void CommandExecute(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Success");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Fail " + exc.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable LoadData(string sqlStr)
        {
            DataTable dtTable = new DataTable();

            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                adapter.Fill(dtTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dtTable;
        }
    }
}
