using SysPerson.Domain.Entities;
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

    //public class Repository<T> : IRepository<T> where T : class
    //{
    //    internal DbContext _contextoBancoDados { get; set; }
    //    internal IDbSet<T> Entidades => _contextoBancoDados.Set<T>();

    //    public Repository(DbContext contextoBancoDados)
    //    {
    //        _contextoBancoDados = contextoBancoDados;
    //    }

    //    private SqlConnection getConexaoBD()
    //    {
    //        string strConexao = ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString;
    //        return new SqlConnection(strConexao);
    //    }

    //    public Guid Adicionar(T entidade)
    //    {
    //        Entidades.Add(entidade);

    //        return (entidade as EntidadeBase).Id;
    //    }

    //    public Guid AdicionarOuAtualizar(T entidade)
    //    {
    //        Entidades.AddOrUpdate(entidade);

    //        return (entidade as EntidadeBase).Id;
    //    }

    //    public bool Alterar(T entidade)
    //    {
    //        Entidades.AddOrUpdate(entidade);

    //        return true;
    //    }

    //    public T Consultar(Guid id)
    //    {
    //        return Entidades.Find(id);
    //    }

    //    public bool Excluir(Guid id)
    //    {
    //        var entidade = Consultar(id);

    //        if (entidade == null)
    //            return false;

    //        Entidades.Remove(entidade);
    //        _contextoBancoDados.SaveChanges();

    //        return true;
    //    }

    //    public IEnumerable<T> ListarTodos()
    //    {
    //        return Entidades.ToList();
    //    }
    //}
}
