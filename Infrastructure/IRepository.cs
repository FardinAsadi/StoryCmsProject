using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace Infrastructure
{
    public interface  IRepository<T> where T :class 
    {
        //IEnumerable<T> GetAll();
        T GetById(int id);
        bool Create(T item);
        bool Update(T item);
        bool Delete(T item);
        //IEnumerable<T> GetByIds(IEnumerable<int> ids);
        //IQueryable<object> GetForDataTables(Expression<Func<object, bool>> filter);
    }
}
