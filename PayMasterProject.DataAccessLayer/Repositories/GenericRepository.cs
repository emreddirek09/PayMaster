using PayMasterProject.DataAccessLayer.Abstract;
using PayMasterProject.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayMasterProject.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var con = new Context();
            con.Set<T>().Remove(t);
            con.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var con = new Context();
            return con.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using var con = new Context();
            return con.Set<T>().Find(id);
        }

        public void Insert(T t)
        {
            using var con = new Context();
            con.Set<T>().Add(t);
            con.SaveChanges();
        }

        public void Update(T t)
        {
            using var con = new Context();
            con.Set<T>().Update(t);
            con.SaveChanges();
        }
    }
}
