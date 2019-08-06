using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;


namespace Debo.Templet.QueryService.EntityFramework
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private DbContext _dbContext;
        public Repository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Dispose()
        {
            if (_dbContext != null)
                _dbContext.Dispose();
        }

        public T FirstOrDefault(Expression<Func<T, bool>> expression)
        {
            return this._dbContext.Set<T>().AsQueryable().Where(expression).FirstOrDefault();
        }

    }
}
