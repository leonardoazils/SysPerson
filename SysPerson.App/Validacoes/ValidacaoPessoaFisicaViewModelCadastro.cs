using FluentValidation;
using SysPerson.App.Models.Pessoa;

namespace SysPerson.App.Validacoes
{
    public class ValidacaoPessoaFisicaViewModelCadastro : AbstractValidator<PessoaFormularioViewModel>
    {
        public ValidacaoPessoaFisicaViewModelCadastro()
        {
            RuleFor(pessoa => pessoa.Cpf).NotEmpty();
            RuleFor(pessoa => pessoa.Nome).NotEmpty();
            RuleFor(pessoa => pessoa.EmailPrincipal).NotEmpty();
            RuleFor(pessoa => pessoa.Profissao).NotEmpty();
            RuleFor(pessoa => pessoa.TelefonePrincipal).NotEmpty();
            RuleFor(pessoa => pessoa.TipoEmpresaId).NotNull();
            RuleFor(pessoa => pessoa.Nascimento).NotEmpty();
            RuleFor(pessoa => pessoa.GeneroId).NotNull();
        }
    }
}