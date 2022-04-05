namespace SysPerson.App.Models
{
    public class PessoaViewModel
    {
        public int Id { get; set; }

        public string TipoPessoa { get; set; }

        public string Nacional { get; set; }

        public string CpfCnpj { get; set; }

        public string NomeRazaoSocial { get; set; }

        public string Porte { get; set; }

        public bool Ativo { get; set; }

        public bool PermiteExcluir { get; set; }
    }
}