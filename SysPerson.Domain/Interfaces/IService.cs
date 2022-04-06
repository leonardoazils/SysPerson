using System;
using System.Collections.Generic;
namespace SysPerson.Domain.Interfaces
{
    public interface IService<T> where T : class
    {
        Guid Adicionar(T entidade);
        void AdicionarOuAtualizar(T entidade);
        bool Alterar(T entidade);
        bool Excluir(Guid id);
        T Consultar(Guid id);
        IEnumerable<T> ListarTodos();
    }
}
