using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Services
{
    public interface IBaseService<T> where T : class
    {
        bool Create(T item);
        bool Delete(T item);
        bool Update(T item);
        T GetById(int id);
    }
}
