using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDapper
{
    public class DapperProgram
    {
        static void Main(string[] args)
        {
            var con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-QBFPK40\\SQLEXPRESS; database=UdemyDapperDb; integrated security=true;";

            //EKLEME İŞLEMLERİ

            // 1. Yöntem
            //con.Execute("insert into Products values('Klavye', 500, 3000)");


            // 2. Yöntem
            //con.Execute("insert into Products values(@name, @price, @stock)", new
            //{
            //    name="Monitör",
            //    price=2500,
            //    stock=200
            //});

            //3.Yöntem
            //con.Execute("insert into Products values(@name, @price, @stock)", new[]
            //{
            //    new {name="Hoparlör", price=550, stock=400},
            //    new {name="Kulaklık", price=230, stock=1000},
            //    new {name="Macbook", price=6000, stock=60},
            //});


            //GÜNCELLEME İŞLEMLERİ

            // 1. Yöntem
            //con.Execute("update Products set name='Macbook Air', price=6500, stock=50 where Id=7");

            // 2. Yöntem
            //con.Execute("update Products set name=@name, price=@price where Id=6", new
            //{
            //    name = "Bluetooth Kulaklık",
            //    price = 300
            //}); //normalde stok verisi de var ancak onu güncellemek istemediğimiz için buraya girmedik.

            //3.Yöntem(Fiyatlara 100 TL zam yapıldığını düşünelim.Diğer parametrelerde değişiklik yapılmayacak varsayalım)
            con.Execute("update Products set price=@price where Id=@Id", new[]
            {
                new {price=4100, Id=1},
                new {price=1600, Id=2},
                new {price=600, Id=3},
                new {price=2600, Id=4},
                new {price=650, Id=5},
                new {price=400, Id=6},
                new {price=6500, Id=7}
            });


            //SİLME İŞLEMLERİ

            // 1. Yöntem
            //con.Execute("delete from Products where Id=7");

            // 2. Yöntem
            //con.Execute("delete from Products where Id=@Id", new[]
            //{
            //    new {Id=4},
            //    new {Id=5},
            //    new {Id=6},
            //});


            Console.WriteLine("işlem tamamlandı");
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
