using System;
using System.Collections.Generic;

namespace SysPerson.Domain.Interfaces
{
    public interface IRepository<TEntidade> where TEntidade : class
    {
        Guid Adicionar(TEntidade entidade);
        
        Guid AdicionarOuAtualizar(TEntidade entidade);
        
        bool Alterar(TEntidade entidade);
        
        bool Excluir(Guid id);
        
        TEntidade Consultar(Guid id);
        
        IEnumerable<TEntidade> ListarTodos();
    }
}
