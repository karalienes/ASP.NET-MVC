using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        //CRUD
        //Type Name(); method oluşturma
        List<T> List();

        T Get(Expression<Func<T, bool>> filter);//silinecek değeri bulma methodu
        void Insert(T p);
        void Update(T p);
        void Delete(T p);

        List<T> List(Expression<Func<T, bool>> filter);
    }
}
