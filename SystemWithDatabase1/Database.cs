using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemWithDatabase1
{

    internal class Database
    {
        DataTable dataTable;
        SqlDataAdapter dataAdapter;
        SqlCommand sqlCommand;
        SqlConnection sqlConnect;
        string conString;

        public Database()
        {
            conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Visual Studio Projects\\SystemWithDatabase1\\SystemWithDatabase1\\Database1.mdf\";Integrated Security=True";
            sqlConnect = new SqlConnection(conString);
            sqlConnect.Open();
        }

        public int cudCMD(string sql)
        {
            sqlCommand = new SqlCommand(sql, sqlConnect);
            return sqlCommand.ExecuteNonQuery();
        }

        public DataTable selectCMD(string sql)
        {
            dataTable = new DataTable();
            dataAdapter = new SqlDataAdapter(sql, conString);
            dataAdapter.Fill(dataTable);
            dataAdapter.Dispose();
            return dataTable;
        }


        public int getScalar(string sql)
        {
            int result = 0;

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    object obj = cmd.ExecuteScalar();
                    if (obj != null && obj != DBNull.Value)
                    {
                        result = Convert.ToInt32(obj);
                    }
                }
            }

            return result;
        }
    }
}