using System;
using System.Linq;
using System.Linq.Expressions;
using AccountAPI.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AccountAPI.Infrastructures.EFCore
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbFactory dbFactory;
        private DbSet<T> dbSet;

        protected DbSet<T> DbSet
        {
            get => dbSet ??= dbFactory.DbContext.Set<T>();
        }

        public Repository(DbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public void Delete(T entity)
        {
           DbSet.Remove(entity);
        }

        public IQueryable<T> List(Expression<Func<T, bool>> expression)
        {
            return DbSet.Where(expression);
        }

        public void Update(T entity)
        {
            DbSet.Update(entity);
        }
    }

}
