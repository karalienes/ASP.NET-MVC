using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {

        Context c = new Context();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = c.Set<T>();
        }
        public void Delete(T p)
        {
            //Entity State komutu
            var deletedEntity = c.Entry(p);
            deletedEntity.State = EntityState.Deleted;
           // _object.Remove(p);
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
            //bir tane değer döndürmeye yarayacaktır.
        }

        public void Insert(T p)
        {
            //Entity State komutu
            var addedEntity = c.Entry(p);
            addedEntity.State = EntityState.Added;
          //  _object.Add(p);
            c.SaveChanges();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public void Update(T p)
        {
            
            //Entity State komutu
            var updatedEntity = c.Entry(p);
            updatedEntity.State = EntityState.Modified;
            c.SaveChanges();
        }
    }
}
