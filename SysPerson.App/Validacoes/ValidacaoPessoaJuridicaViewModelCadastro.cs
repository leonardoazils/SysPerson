using FluentValidation;
using SysPerson.App.Models.Pessoa;
using System;

namespace SysPerson.App.Validacoes
{
    public class ValidacaoPessoaJuridicaViewModelCadastro : AbstractValidator<PessoaFormularioViewModel>
    {
        public ValidacaoPessoaJuridicaViewModelCadastro()
        {
            RuleFor(pessoa => pessoa.Nacional).NotEmpty();
            RuleFor(pessoa => pessoa.Cnpj).NotEmpty();
            RuleFor(pessoa => pessoa.RazaoSocial).NotEmpty();
            RuleFor(pessoa => pessoa.TipoEmpresaPjId).NotNull().NotEqual(Guid.Empty);
            RuleFor(pessoa => pessoa.PorteId).NotNull().NotEqual(Guid.Empty);
            RuleFor(pessoa => pessoa.TelefonePrincipalEmpresa).NotEmpty();
            RuleFor(pessoa => pessoa.EmailPrincipalEmpresa).NotEmpty();
            RuleFor(pessoa => pessoa.CapitalSocial).NotEmpty().GreaterThan(0);
        }
    }
}