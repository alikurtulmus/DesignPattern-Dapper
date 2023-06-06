using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDapper_Transaction
{
    public class DapperTransaction
    {
        static void Main(string[] args)
        {
            var con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-QBFPK40\\SQLEXPRESS; database=UdemyDapperDb; integrated security=true;";

            con.Open();
            var transaction = con.BeginTransaction();
            con.Execute("update BankAccounts set Money=4500 where id=1", transaction:transaction);
            con.Execute("update BankAccounts set Money=6500 where id=2", transaction:transaction);
            transaction.Commit();
            con.Close();
        }
    }
}
