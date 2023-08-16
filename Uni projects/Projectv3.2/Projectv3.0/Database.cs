using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Projectv3._0
{
    class Database
    {
        public static string con = @"data source=DESKTOP-6UPONFK; initial catalog=asra; integrated security=true;";
        public static SqlConnection sql = new SqlConnection(con);
        public static SqlConnection opendb()
        {
            if (sql.State == System.Data.ConnectionState.Open)
            {
                return sql;
            }
            else
            {
                sql.Open();
                return sql;
            }
        }
    }
}
