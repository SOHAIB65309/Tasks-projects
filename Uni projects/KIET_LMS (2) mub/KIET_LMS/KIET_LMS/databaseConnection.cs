using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace KIET_LMS
{
    static class databaseConnection
    {
        public static string con = @"data source=DESKTOP-QOP7VVI\SQLEXPRESS; initial catalog=KIET_LMS; integrated security=true;";
        public static SqlConnection sql = new SqlConnection(con);

        public static SqlConnection getConnection() 
        {
            if (sql.State == System.Data.ConnectionState.Closed)
            {
                sql.Open();
            }

            return sql;
        }

        public static DataTable getTable(string query)
        {
            SqlCommand cmd = new SqlCommand(query, databaseConnection.getConnection());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            return dt;
        }

        public static void Execute(string query) 
        {
            SqlCommand cmd = new SqlCommand(query,databaseConnection.getConnection());
            cmd.ExecuteNonQuery();
        }
       
    }
}
