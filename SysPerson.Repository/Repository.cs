using SysPerson.Domain.Interfaces;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace SysPerson.Repository
{
    public class Repository<T> : IRepository<T>, IDisposable where T : class
    {
        private SysPersonContext _context;

        public Repository()
        {
            _context = new SysPersonContext();
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(Func<T, bool> predicate)
        {
            _context.Set<T>()
                .Where(predicate).ToList()
                .ForEach(del => _context.Set<T>().Remove(del));
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            if (_context != null)
                _context.Dispose();

            GC.SuppressFinalize(this);
        }
    }
}
