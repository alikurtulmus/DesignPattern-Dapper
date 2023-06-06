using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace UsingDapper_StoreProcedure
{
    public class DapperSP
    {
        static void Main(string[] args)
        {
            var con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-QBFPK40\\SQLEXPRESS; database=UdemyDapperDb; integrated security=true;";

            // 1. Stored Procedure: sp_addProduct 
            //con.Execute("sp_addProduct", new
            //{
            //    name="Kitap",
            //    price=15,
            //    stock=50
            //},commandType: System.Data.CommandType.StoredProcedure);

            // 2. Stored Procedure: sp_updateProduct 
            //con.Execute("sp_updateProduct", new
            //{
            //    name = "Kitap",
            //    price = 30,
            //    stock = 150,
            //    id=7
            //}, commandType: System.Data.CommandType.StoredProcedure);

            // 3. Stored Procedure: sp_deleteProduct 
            //con.Execute("sp_deleteProduct", new
            //{
            //    id = 7
            //}, commandType: System.Data.CommandType.StoredProcedure);

            // 4. Stored Procedure: sp_getProducts
            var products = con.Query<Product>("sp_getProducts", commandType: System.Data.CommandType.StoredProcedure);
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

    }
}
