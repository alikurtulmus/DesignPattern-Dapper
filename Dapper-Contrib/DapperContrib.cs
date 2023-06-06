using Dapper_Contrib.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_Contrib
{
    public class DapperContrib
    {
        static void Main(string[] args)
        {
            ProductRepository repository = new ProductRepository();

            //repository.Add(new Entities.Product()
            //{
            //    Name = "Hard Disk",
            //    Price = 500,
            //    Stock = 200
            //});

            //repository.Update(new Entities.Product
            //{
            //    Id = 10,
            //    Price = 600,
            //    Stock = 245
            //});

            //CategoryRepository categoryRepository = new CategoryRepository();
            //categoryRepository.Add(new Entities.Category
            //{
            //    Name = "Beyaz Eşya"
            //});
        }
    }
}
