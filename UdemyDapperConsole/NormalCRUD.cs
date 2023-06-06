using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyDapperConsole
{
    public class NormalCRUD
    {
        static void Main(string[] args)
        {
            var con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-QBFPK40\\SQLEXPRESS; database=UdemyDapperDb; integrated security=true;";

            //EKLEME İŞLEMİ - DAPPER kullanmadan yapılacak ekleme işlemlerinde aşağıdaki kodların tamamının eklenecek her ürün için yazılması gerekmektedir.
            //var cmd = new SqlCommand();
            //cmd.Connection= con;
            //cmd.CommandType = System.Data.CommandType.Text;
            //cmd.CommandText = "insert into Products values('Samsung', 4000, 30)";
            //con.Open();
            //var affectedRows=cmd.ExecuteNonQuery();
            //con.Close();

            //var cmd2 = new SqlCommand();
            //cmd2.Connection = con;
            //cmd2.CommandType = System.Data.CommandType.Text;
            //cmd2.CommandText = "insert into Products values('Samsung2', 4000, 30)";
            //con.Open();
            //var affectedRows2 = cmd.ExecuteNonQuery();
            //con.Close();

            Console.WriteLine("işlem tamamlandı");
        }
    }
}
