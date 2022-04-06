using SysPerson.Domain.Entities;
using SysPerson.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;

namespace SysPerson.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        internal DbContext _contextoBancoDados { get; set; }
        internal IDbSet<T> Entidades => _contextoBancoDados.Set<T>();

        public Repository(DbContext contextoBancoDados)
        {
            _contextoBancoDados = contextoBancoDados;
        }

        private SqlConnection getConexaoBD()
        {
            string strConexao = ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString;
            return new SqlConnection(strConexao);
        }

        public Guid Adicionar(T entidade)
        {
            Entidades.Add(entidade);

            return (entidade as EntidadeBase).Id;
        }

        public Guid AdicionarOuAtualizar(T entidade)
        {
            Entidades.AddOrUpdate(entidade);
            
            return (entidade as EntidadeBase).Id;
        }

        public bool Alterar(T entidade)
        {
            Entidades.AddOrUpdate(entidade);

            return true;
        }

        public T Consultar(Guid id)
        {
            return Entidades.Find(id);
        }

        public bool Excluir(Guid id)
        {
            var entidade = Consultar(id);
            
            if (entidade == null)
                return false;
            
            Entidades.Remove(entidade);
            _contextoBancoDados.SaveChanges();
            
            return true;
        }

        public IEnumerable<T> ListarTodos()
        {
            return Entidades.ToList();
        }
    }
}
