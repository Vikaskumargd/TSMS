using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TSMS.Repositories.Interfaces;
using TSMS.Entities;
using System.Linq.Expressions;

namespace TSMS.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _dbContext;
        protected DbSet<T> DbSet;

        public Repository(ApplicationDbContext context)
        {
            _dbContext = context;
            DbSet = context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);

            Save();
        }

        public T Get<TKey>(TKey id)
        {
            return DbSet.Find(id);
        }

        //public IQueryable<T> GetAll()
        //{
        //    return DbSet;
        //}

        public virtual IEnumerable<T> List()
        {
            return _dbContext.Set<T>().AsEnumerable();
        }

        public virtual IEnumerable<T> List(Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>()
                   .Where(predicate)
                   .AsEnumerable();
        }

        public void Update(T entity)
        {
            Save();
        }

        private void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
