using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Infrastructure
{
    public class UnitOfWork:IUnitOFWork, IDisposable
    {

        private Context _dbcontext;
        public UnitOfWork()
        {
            _dbcontext = context;
        }


        public Context context 
        {
               
            get
            {

                if (_dbcontext == null)
                {
                    return _dbcontext = new Context();
                }
                return _dbcontext;
            }
                
          
           
        }



        //private testEntities Get()
        //{
        //    var context = _dbContext ?? new testEntities();
        //    context.Database.CommandTimeout = 120;
        //    return context;
        //}
        public bool Commit()
        {
            var result = true;
            try
            {
                _dbcontext.SaveChanges();
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }
        bool disposed ;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _dbcontext.Dispose();
                }
            }
            disposed = true;
        }
       
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        
    }
}
