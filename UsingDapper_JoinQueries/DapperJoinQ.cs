using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDapper_JoinQueries
{
    public class DapperJoinQ
    {
        static void Main(string[] args)
        {
            var con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-QBFPK40\\SQLEXPRESS; database=UdemyDapperDb; integrated security=true;";

            //var product = con.QueryFirst<Product>("select*from Products where Id=1");

            // 1. YÖNTEM

            //var products = con.Query<Product, ProductCategory, Product>(@"select * from Products inner join ProductCategory on Products.Id=ProductCategory.ProductId where ProductCategory.CategoryId=@categoryId", (product, productCategory) => { return product; }, new {categoryId= 3});

            // 2. YÖNTEM

            var products2 = con.Query<Product>(@"select Product.* from Products inner join ProductCategory on Products.Id=ProductCategory.ProductId where ProductCategory.CategoryId=@categoryId", new { categoryId = 3 });

            foreach (var item in products2) 
            { 
                Console.WriteLine(item.Name);
            }
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public List<ProductCategory> ProductCategories { get; set;}
    }

    public class ProductCategory
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
        public Category Categories { get; set; }
        public Product Products { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
    }
}
