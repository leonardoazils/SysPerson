using SysPerson.Framework.Enums;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SysPerson.App.Models.Pessoa
{
    public class PessoaFormularioViewModel
    {
        public Guid Id { get; set; }

        public Guid EstadoCivilId { get; set; }

        public Guid TipoEmpresaId { get; set; }

        public Guid TipoEmpresaPjId { get; set; }

        public Guid GeneroId { get; set; }

        public Guid PorteId { get; set; }

        public Guid CaracterizacaoCapitalId { get; set; }

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

        public string Nascimento { get; set; }

        public string Nacionalidade { get; set; }

        public string Website { get; set; }

        public string DataUltimaAtualizacao { get; set; }

        public decimal QuantidadeQuota { get; set; }

        public decimal ValorQuota { get; set; }

        public decimal CapitalSocial { get; set; }

        public bool Ativa { get; set; }

        public string DataConstituicao { get; set; }

        public NacionalEnum Nacional { get; set; }

        public bool NovoCadastro => Id.Equals(null) || Id.Equals(Guid.Empty);

        public IEnumerable<SelectListItem> SelectListItemListaTipoEmpresa { get; set; } = new List<SelectListItem>();

        public IEnumerable<SelectListItem> SelectListItemListaTipoEmpresaPj { get; set; } = new List<SelectListItem>();

        public IEnumerable<SelectListItem> SelectListItemListaEstadoCivil { get; set; } = new List<SelectListItem>();

        public IEnumerable<SelectListItem> SelectListItemListaGenero { get; set; } = new List<SelectListItem>();

        public IEnumerable<SelectListItem> SelectListItemListaPorte { get; set; } = new List<SelectListItem>();

        public IEnumerable<SelectListItem> SelectListItemListaCaracterizacaoCapital { get; set; } = new List<SelectListItem>();

        public IEnumerable<SelectListItem> SelectListItemListaTipoPessoa { get; set; } = new List<SelectListItem>();
    }
}