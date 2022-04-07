using FluentValidation;
using SysPerson.App.Models.Pessoa;
using System;

namespace SysPerson.App.Validacoes
{
    public class ValidacaoPessoaFisicaViewModelCadastro : AbstractValidator<PessoaFormularioViewModel>
    {
        public ValidacaoPessoaFisicaViewModelCadastro()
        {
            RuleFor(pessoa => pessoa.Nacional).NotEmpty();
            RuleFor(pessoa => pessoa.Cpf).NotEmpty();
            RuleFor(pessoa => pessoa.Nome).NotEmpty();
            RuleFor(pessoa => pessoa.EmailPrincipal).NotEmpty();
            RuleFor(pessoa => pessoa.Profissao).NotEmpty();
            RuleFor(pessoa => pessoa.TelefonePrincipal).NotEmpty();
            RuleFor(pessoa => pessoa.TipoEmpresaId).NotNull().NotEqual(Guid.Empty);
            RuleFor(pessoa => pessoa.Nascimento).NotEmpty();
            RuleFor(pessoa => pessoa.GeneroId).NotNull().NotEqual(Guid.Empty);
        }
    }
}