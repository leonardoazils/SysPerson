using SysPerson.Domain.Entities;
using SysPerson.Domain.Interfaces;

namespace SysPerson.Service
{
    public class PessoaService : Service<Pessoa>
    {
        public PessoaService(IRepository<Pessoa> repositorio) : base(repositorio)
        {
        }
    }
}
