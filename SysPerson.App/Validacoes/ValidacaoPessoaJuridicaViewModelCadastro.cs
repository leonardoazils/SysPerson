using FluentValidation;
using SysPerson.App.Models.Pessoa;

namespace SysPerson.App.Validacoes
{
    public class ValidacaoPessoaJuridicaViewModelCadastro : AbstractValidator<PessoaFormularioViewModel>
    {
        public ValidacaoPessoaJuridicaViewModelCadastro()
        {
            RuleFor(pessoa => pessoa.Cnpj).NotEmpty();
            RuleFor(pessoa => pessoa.RazaoSocial).NotEmpty();
            RuleFor(pessoa => pessoa.TipoEmpresaPjId).NotNull();
            RuleFor(pessoa => pessoa.PorteId).NotNull();
            RuleFor(pessoa => pessoa.TelefonePrincipalEmpresa).NotEmpty();
            RuleFor(pessoa => pessoa.EmailPrincipalEmpresa).NotEmpty();
            RuleFor(pessoa => pessoa.CapitalSocial).NotEmpty().GreaterThan(0);
        }
    }
}