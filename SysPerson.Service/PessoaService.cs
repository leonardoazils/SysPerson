using SysPerson.Domain.Entities;
using SysPerson.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SysPerson.Service
{
    public class PessoaService
    {
        Repository<Pessoa> _repository;

        public PessoaService()
        {
            _repository = new Repository<Pessoa>();
        }

        public List<Pessoa> Get() =>
            _repository.Get(p => true).ToList();

        public Pessoa Get(Guid id) =>
            _repository.Get(p => p.Id == id).FirstOrDefault();

        public Pessoa Create(Pessoa pessoa)
        {
            _repository.Add(pessoa);
            _repository.Commit();
            
            return pessoa;
        }

        public void Update(Pessoa pessoa)
        { 
            _repository.Update(pessoa);
            _repository.Commit();
        }

        public void Remove(Pessoa pessoa)
        { 
            _repository.Delete(p => p.Id == pessoa.Id);
            _repository.Commit();
        }

        public void Remove(Guid id)
        {
            _repository.Delete(p => p.Id == id);
            _repository.Commit();
        }
    }
}
