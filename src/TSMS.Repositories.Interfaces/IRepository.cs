using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TSMS.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        T Get<TKey>(TKey id);
       // IQueryable<T> GetAll();

        IEnumerable<T> List();
        IEnumerable<T> List(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Update(T entity);
    }
}
