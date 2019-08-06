using System;
using System.Linq.Expressions;

namespace Debo.Templet.QueryService
{
    public interface IRepository<T> : IDisposable where T : class
    {
        T FirstOrDefault(Expression<Func<T, bool>> expression);
    }
}
