using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;

namespace Services
{
    public class BaseService<T> :IBaseService<T> where T :class 
    {
        private readonly IRepository<T> _repository;
        public BaseService(IRepository<T> repository)
        {
            _repository = repository;
        }
        public bool Create(T item)
        {
            return _repository.Create(item);
           
        }
        public bool Delete(T item)
        {
            return _repository.Delete(item);
        }
        public bool Update(T item)
        {
            return _repository.Update(item);
        }
        public T GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
