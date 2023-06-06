using Dapper.Contrib.Extensions;
using Dapper_Contrib.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_Contrib.Repositories
{
    public class GenericRepository<T> where T : class, new()
    {
        public List<T> GetAll()
        {
            var con = Db.GetConnection();
            return con.GetAll<T>().ToList();
        }

        public void Add(T item)
        {
            var con = Db.GetConnection();
            con.Insert(item);
        }
        public void Update(T item)
        {
            var con = Db.GetConnection();
            con.Update(item);
        }
        public void Delete(T item)
        {
            var con = Db.GetConnection();
            con.Delete(item);
        }
        public T GetById(int id)
        {
            var con = Db.GetConnection();
            return con.Get<T>(id);
        }
    }
}
