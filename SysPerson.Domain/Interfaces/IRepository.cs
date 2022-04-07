using System;
using System.Linq;
using System.Linq.Expressions;

namespace SysPerson.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();

        IQueryable<T> Get(Expression<Func<T, bool>> predicate);

        void Add(T entity);

        void Update(T entity);

        void Delete(Func<T, bool> predicate);

        void Commit();

        void Dispose();
    }
}
