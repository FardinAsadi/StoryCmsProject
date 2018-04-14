 using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;


namespace Infrastructure
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private UnitOfWork _unitofwork;

        public UnitOfWork unitofwork
        {
            get
            {
                if (_unitofwork == null)
                {
                    return _unitofwork= new UnitOfWork();
                }

                return _unitofwork;

            }
           
        }

        public Repository()
        {

            _unitofwork = unitofwork;

        }
        public Repository(UnitOfWork unitofwork)
        {

            //_unitofwork = unitofwork;

        }

        private DbSet<TEntity> DbSet{get { return _unitofwork.context.Set<TEntity>(); }}

       
        
      
        public virtual IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = DbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] {','}, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public virtual TEntity GetById(int id)
        {
            return DbSet.Find(id);
        }

        public virtual bool Create(TEntity entity)
        {
            var result = true;
            try
            {
                DbEntityEntry dbEntityEntry = _unitofwork.context.Entry(entity);
                if (dbEntityEntry.State != EntityState.Detached)
                {
                    dbEntityEntry.State = EntityState.Added;
                }
                else
                {
                    DbSet.Add(entity);
                }
                _unitofwork.Commit();
            }
            catch (Exception ex)
            {
                result = false;
            }

            return result;
        }


        public virtual bool Delete(TEntity entityToDelete)
        {
            var result = true;
            try
            {
                if (_unitofwork.context.Entry(entityToDelete).State == EntityState.Detached)
                {
                    DbSet.Attach(entityToDelete);
                }
                DbSet.Remove(entityToDelete);
           
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        public virtual bool Update(TEntity entityToUpdate)
        {
            var result = true;
            try
            {
                DbSet.Attach(entityToUpdate);
                _unitofwork.context.Entry(entityToUpdate).State = EntityState.Modified;
         
            }
            catch (Exception ex)
            {
                result = false;
            }

            //result = result && _unitOfWork.Commit();
            return result;
        }
    }
}