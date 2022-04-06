using SysPerson.App.Models.Pessoa;
using SysPerson.App.Validacoes;
using SysPerson.Domain.Entities;
using SysPerson.Framework.Extensions;
using SysPerson.Framework.Seeders;
using SysPerson.Service;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SysPerson.App.Controllers
{
    public class PessoaController : Controller
    {
        private const int PESSOA_FISICA = 1;
        private const int PESSOA_NAO_SELECIONADA = 0;
        private readonly PessoaService _pessoaService = new PessoaService();

        private bool ValidarPreenchimentoPessoaFisica(PessoaFormularioViewModel model)
        {
            var validador = new ValidacaoPessoaFisicaViewModelCadastro();
            return validador.Validate(model).IsValid;
        }

        private bool ValidarPreenchimentoPessoaJuridica(PessoaFormularioViewModel model)
        {
            var validador = new ValidacaoPessoaJuridicaViewModelCadastro();
            return validador.Validate(model).IsValid;
        }

        private PessoaFormularioViewModel CarregarDadosCadastro(PessoaFormularioViewModel model)
        {
            try
            {
                model.SelectListItemListaGenero = new Genero().Obter().DropDownList();
                model.SelectListItemListaEstadoCivil = new EstadoCivil().Obter().DropDownList();
                model.SelectListItemListaPorte = new Porte().Obter().DropDownList();
                model.SelectListItemListaTipoEmpresa = new TipoEmpresa().Obter().DropDownList();
                model.SelectListItemListaTipoEmpresaPj = new TipoEmpresaPj().Obter().DropDownList();
                model.SelectListItemListaTipoPessoa = new TipoPessoa().Obter().DropDownList(PESSOA_FISICA);
                model.SelectListItemListaCaracterizacaoCapital = new CaracterizacaoCapital().Obter().DropDownList();

                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Pessoa MontarEntidadePessoaFisica(PessoaFormularioViewModel model)
        {
            try
            {
                var pessoa = new Pessoa();

                pessoa.TipoPessoaId = model.TipoPessoaId;
                pessoa.EstadoCivilId = model.EstadoCivilId;
                pessoa.TipoEmpresaId = model.TipoEmpresaId;
                pessoa.GeneroId = model.GeneroId;
                pessoa.Nacional = model.Nacional;
                pessoa.Ativa = model.Ativa;
                pessoa.DataUltimaAtualizacao = DateTime.Now;
                pessoa.Cpf = model.Cpf;
                pessoa.Nome = model.Nome;
                pessoa.EmailPrincipal = model.EmailPrincipal;
                pessoa.Profissao = model.Profissao;
                pessoa.TelefonePrincipal = model.TelefonePrincipal;
                pessoa.TelefoneSecundario = model.TelefoneSecundario;
                pessoa.TelefoneReserva = model.TelefoneReserva;
                pessoa.Nascimento = DateTime.Parse(model.Nascimento);
                pessoa.Nacionalidade = model.Nacionalidade;

                return pessoa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Pessoa MontarEntidadePessoaJuridica(PessoaFormularioViewModel model)
        {
            try
            {
                var pessoa = new Pessoa();

                if (model.Id != Guid.Empty)
                    pessoa.Id = model.Id;

                pessoa.TipoEmpresaPjId = model.TipoEmpresaPjId;
                pessoa.PorteId = model.PorteId;
                pessoa.CaracterizacaoCapitalId = model.CaracterizacaoCapitalId;
                pessoa.Cnpj = model.Cnpj;
                pessoa.RazaoSocial = model.RazaoSocial;
                pessoa.NomeFantasia = model.NomeFantasia;
                pessoa.DataConstituicao = !string.IsNullOrEmpty(model.DataConstituicao) ? DateTime.Parse(model.DataConstituicao) : (DateTime?)null;
                pessoa.TelefonePrincipalEmpresa = model.TelefonePrincipalEmpresa;
                pessoa.TelefoneSecundarioEmpresa = model.TelefoneSecundarioEmpresa;
                pessoa.TelefoneReservaEmpresa = model.TelefoneReservaEmpresa;
                pessoa.Website = model.Website;
                pessoa.EmailPrincipal = model.EmailPrincipal;
                pessoa.QuantidadeQuota = model.QuantidadeQuota;
                pessoa.ValorQuota = model.ValorQuota;
                pessoa.CapitalSocial = model.CapitalSocial;

                return pessoa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult Index()
        {
            var listaPessoas = new PessoaViewModelIndex();
            var pessoas = new List<PessoaViewModel>();

            var pessoa1 = new PessoaViewModel();

            pessoa1.Id = Guid.NewGuid();
            pessoa1.CpfCnpj = "085.891.079-90";
            pessoa1.NomeRazaoSocial = "Leonardo Augusto Zils";
            pessoa1.TipoPessoa = "Pessoa Física";
            pessoa1.Nacional = "Sim";
            pessoa1.Porte = "OUTROS";
            pessoa1.Ativo = true;
            pessoa1.PermiteExcluir = true;

            pessoas.Add(pessoa1);

            var pessoa2 = new PessoaViewModel();

            pessoa2.Id = Guid.NewGuid();
            pessoa2.CpfCnpj = "999.999.999-99";
            pessoa2.NomeRazaoSocial = "Fulano de Tal";
            pessoa2.TipoPessoa = "Pessoa Juridica";
            pessoa2.Nacional = "Sim";
            pessoa2.Ativo = false;
            pessoa2.PermiteExcluir = false;
            pessoa2.Porte = "OUTROS";

            pessoas.Add(pessoa2);

            listaPessoas.Pessoas = new List<PessoaViewModel>();
            listaPessoas.Pessoas.AddRange(pessoas);

            return View(listaPessoas);
        }

        public ActionResult Adicionar()
        {
            try
            {
                return View("Formulario", CarregarDadosCadastro(new PessoaFormularioViewModel() { Ativa = true }));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Adicionar(PessoaFormularioViewModel model, string btnSalvarContinuar)
        {
            if(model.TipoPessoaId == PESSOA_NAO_SELECIONADA)
            {
                TempData["warning"] = "É necessário selecionar o tipo de pessoa e preencher os campos obrigatórios para continuar.";

                return View("Formulario", CarregarDadosCadastro(model));
            }
            else if(model.TipoPessoaId == PESSOA_FISICA)
            {
                if(!ValidarPreenchimentoPessoaFisica(model))
                {
                    TempData["warning"] = "Há campos obrigatórios não preenchidos, por favor, verifique.";

                    return View("Formulario", CarregarDadosCadastro(model));
                }
                else
                {
                    var pessoaFisica = MontarEntidadePessoaFisica(model);

                    _pessoaService.Create(pessoaFisica);
                }
            }
            else
            {
                if (!ValidarPreenchimentoPessoaJuridica(model))
                {
                    TempData["warning"] = "Há campos obrigatórios não preenchidos, por favor, verifique.";

                    return View("Formulario", CarregarDadosCadastro(model));
                }
                else
                {
                    var pessoaJuridica = MontarEntidadePessoaJuridica(model);

                    _pessoaService.Create(pessoaJuridica);
                }
            }

            TempData["warning"] = "Registro de pessoa salvo com sucesso.";

            return RedirectToAction(btnSalvarContinuar != null ? "Adicionar" : "Index");
        }
    }
}