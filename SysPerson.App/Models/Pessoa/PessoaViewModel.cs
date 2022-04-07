using SysPerson.Framework.Enums;
using System;

namespace SysPerson.App.Models.Pessoa
{
    public class PessoaViewModel
    {
        public Guid Id { get; set; }

        public string TipoPessoa { get; set; }

        public string Nacional { get; set; }

        public string CpfCnpj { get; set; }

        public string NomeRazaoSocial { get; set; }

        public string Porte { get; set; }

        public string SituacaoPessoaDescricao { get; set; }

        public bool Ativo { get; set; }

        public bool PermiteExcluir { get; set; }

        public SituacaoPessoaEnum SituacaoPessoa { get; set; }
    }
}