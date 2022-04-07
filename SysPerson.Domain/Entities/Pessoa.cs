using SysPerson.Framework.Enums;
using System;

namespace SysPerson.Domain.Entities
{
    public class Pessoa : EntidadeBase
    {
        public Guid? EstadoCivilId { get; set; }

        public Guid? TipoEmpresaId { get; set; }

        public Guid? TipoEmpresaPjId { get; set; }

        public Guid? GeneroId { get; set; }

        public Guid? PorteId { get; set; }

        public Guid? CaracterizacaoCapitalId { get; set; }

        public int TipoPessoaId { get; set; }

        public string Cpf { get; set; }

        public string Cnpj { get; set; }

        public string Nome { get; set; }

        public string RazaoSocial { get; set; }

        public string NomeFantasia { get; set; }

        public string EmailPrincipal { get; set; }

        public string Profissao { get; set; }

        public string TelefonePrincipal { get; set; }

        public string TelefoneSecundario { get; set; }

        public string TelefoneReserva { get; set; }

        public string TelefonePrincipalEmpresa { get; set; }

        public string TelefoneSecundarioEmpresa { get; set; }

        public string TelefoneReservaEmpresa { get; set; }

        public string Nacionalidade { get; set; }

        public string Website { get; set; }

        public decimal? QuantidadeQuota { get; set; }

        public decimal? ValorQuota { get; set; }

        public decimal? CapitalSocial { get; set; }

        public DateTime? DataConstituicao { get; set; }

        public DateTime? Nascimento { get; set; }

        public DateTime? DataUltimaAtualizacao { get; set; }

        public NacionalEnum Nacional { get; set; }

        public SituacaoPessoaEnum SituacaoPessoa { get; set; }
    }
}
