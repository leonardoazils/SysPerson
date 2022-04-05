using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SysPerson.App.Models.Pessoa
{
    public class PessoaFormularioViewModel
    {
        public Guid Id { get; set; }

        public string Cpf { get; set; }

        public bool NovoCadastro => Id.Equals(null) || Id.Equals(Guid.Empty);
    }
}