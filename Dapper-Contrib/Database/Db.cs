using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_Contrib.Database
{
    public static class Db
    {
        public static SqlConnection GetConnection()
        {
            var con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-QBFPK40\\SQLEXPRESS; database=UdemyDapperDb; integrated security=true;";
            return con;
        }
    }
}
