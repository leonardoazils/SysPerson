using SysPerson.App.Models.Pessoa;
using SysPerson.App.Validacoes;
using SysPerson.Domain.Entities;
using SysPerson.Framework.Enums;
using SysPerson.Framework.Extensions;
using SysPerson.Framework.Seeders;
using SysPerson.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SysPerson.App.Controllers
{
    public class PessoaController : Controller
    {
        private const int PESSOA_FISICA = 1;
        private const int PESSOA_NAO_SELECIONADA = 0;
        private readonly PessoaService _pessoaService = new PessoaService();

        private bool GravarPessoa(PessoaFormularioViewModel model, bool atualizar, out string erro)
        {
            try
            {
                erro = string.Empty;

                if (model.TipoPessoaId == PESSOA_NAO_SELECIONADA)
                {
                    erro = "É necessário selecionar o tipo de pessoa e preencher os campos obrigatórios para continuar.";

                    return false;
                }
                else if (model.TipoPessoaId == PESSOA_FISICA)
                {
                    if (!ValidarPreenchimentoPessoaFisica(model))
                    {
                        erro = "Há campos obrigatórios não preenchidos, por favor, verifique.";

                        return false;
                    }
                    else
                    {
                        if (!atualizar)
                            model.SituacaoPessoa = SituacaoPessoaEnum.EmElaboracao;

                        var pessoaFisica = MontarEntidadePessoaFisica(model);

                        if (atualizar)
                            _pessoaService.Update(pessoaFisica);
                        else
                            _pessoaService.Create(pessoaFisica);

                        return true;
                    }
                }
                else
                {
                    if (!ValidarPreenchimentoPessoaJuridica(model))
                    {
                        erro = "Há campos obrigatórios não preenchidos, por favor, verifique.";

                        return false;
                    }
                    else
                    {
                        var pessoaJuridica = MontarEntidadePessoaJuridica(model);

                        if (atualizar)
                            _pessoaService.Update(pessoaJuridica);
                        else
                            _pessoaService.Create(pessoaJuridica);

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

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

        private Pessoa MontarEntidadePessoaFisica(PessoaFormularioViewModel model)
        {
            try
            {
                var pessoa = new Pessoa();

                if (model.Id != Guid.Empty)
                    pessoa.Id = model.Id;

                pessoa.TipoPessoaId = model.TipoPessoaId;
                pessoa.EstadoCivilId = model.EstadoCivilId;
                pessoa.TipoEmpresaId = model.TipoEmpresaId;
                pessoa.GeneroId = model.GeneroId;
                pessoa.Nacional = model.Nacional;
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
                pessoa.SituacaoPessoa = model.SituacaoPessoa;

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
                pessoa.SituacaoPessoa = model.SituacaoPessoa;

                return pessoa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private PessoaFormularioViewModel CarregarDadosCadastro(PessoaFormularioViewModel model)
        {
            try
            {
                model.SelectListItemListaGenero = new Genero().Obter().DropDownList(model.GeneroId);
                model.SelectListItemListaEstadoCivil = new EstadoCivil().Obter().DropDownList(model.EstadoCivilId);
                model.SelectListItemListaPorte = new Porte().Obter().DropDownList(model.PorteId);
                model.SelectListItemListaTipoEmpresa = new TipoEmpresa().Obter().DropDownList(model.TipoEmpresaId);
                model.SelectListItemListaTipoEmpresaPj = new TipoEmpresaPj().Obter().DropDownList(model.TipoEmpresaPjId);
                model.SelectListItemListaTipoPessoa = new TipoPessoa().Obter().DropDownList(PESSOA_FISICA);
                model.SelectListItemListaCaracterizacaoCapital = new CaracterizacaoCapital().Obter().DropDownList(model.CaracterizacaoCapitalId);

                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private PessoaFormularioViewModel MontarModeloPessoaFisica(Pessoa pessoa)
        {
            try
            {
                var modelo = new PessoaFormularioViewModel();

                modelo.Id = pessoa.Id;
                modelo.TipoPessoaId = pessoa.TipoPessoaId;
                modelo.EstadoCivilId = pessoa.EstadoCivilId.HasValue ? pessoa.EstadoCivilId.Value : Guid.Empty;
                modelo.TipoEmpresaId = pessoa.TipoEmpresaId.HasValue ? pessoa.TipoEmpresaId.Value : Guid.Empty;
                modelo.GeneroId = pessoa.GeneroId.HasValue ? pessoa.GeneroId.Value : Guid.Empty;
                modelo.Nacional = pessoa.Nacional;
                modelo.DataUltimaAtualizacao = pessoa.DataUltimaAtualizacao.Value.ToShortDateString();
                modelo.Cpf = pessoa.Cpf;
                modelo.Nome = pessoa.Nome;
                modelo.EmailPrincipal = pessoa.EmailPrincipal;
                modelo.Profissao = pessoa.Profissao;
                modelo.TelefonePrincipal = pessoa.TelefonePrincipal;
                modelo.TelefoneSecundario = pessoa.TelefoneSecundario;
                modelo.TelefoneReserva = pessoa.TelefoneReserva;
                modelo.Nascimento = pessoa.Nascimento.Value.ToShortDateString();
                modelo.Nacionalidade = pessoa.Nacionalidade;
                modelo.SituacaoPessoa = pessoa.SituacaoPessoa;

                if (pessoa.SituacaoPessoa == SituacaoPessoaEnum.EmElaboracao)
                    modelo.SituacaoPessoaDescricao = "Em Elaboração";
                else if (pessoa.SituacaoPessoa == SituacaoPessoaEnum.Ativado)
                    modelo.SituacaoPessoaDescricao = "Ativado";
                else
                    modelo.SituacaoPessoaDescricao = "Desativado";

                return modelo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private PessoaFormularioViewModel MontarModeloPessoaJuridica(Pessoa pessoa)
        {
            try
            {
                var modelo = new PessoaFormularioViewModel();

                modelo.Id = pessoa.Id;
                modelo.TipoEmpresaPjId = pessoa.TipoEmpresaPjId.HasValue ? pessoa.TipoEmpresaPjId.Value : Guid.Empty;
                modelo.PorteId = pessoa.PorteId.HasValue ? pessoa.PorteId.Value : Guid.Empty;
                modelo.CaracterizacaoCapitalId = pessoa.CaracterizacaoCapitalId.HasValue ? pessoa.CaracterizacaoCapitalId.Value : Guid.Empty;
                modelo.Cnpj = pessoa.Cnpj;
                modelo.RazaoSocial = pessoa.RazaoSocial;
                modelo.NomeFantasia = pessoa.NomeFantasia;
                modelo.DataConstituicao = pessoa.DataConstituicao.HasValue ? pessoa.DataConstituicao.Value.ToShortDateString() : null;
                modelo.TelefonePrincipalEmpresa = pessoa.TelefonePrincipalEmpresa;
                modelo.TelefoneSecundarioEmpresa = pessoa.TelefoneSecundarioEmpresa;
                modelo.TelefoneReservaEmpresa = pessoa.TelefoneReservaEmpresa;
                modelo.Website = pessoa.Website;
                modelo.EmailPrincipal = pessoa.EmailPrincipal;
                modelo.QuantidadeQuota = pessoa.QuantidadeQuota.HasValue ? pessoa.QuantidadeQuota.Value : decimal.Zero;
                modelo.ValorQuota = pessoa.ValorQuota.HasValue ? pessoa.ValorQuota.Value : decimal.Zero;
                modelo.CapitalSocial = pessoa.CapitalSocial.HasValue ? pessoa.CapitalSocial.Value : decimal.Zero;
                modelo.SituacaoPessoa = pessoa.SituacaoPessoa;

                if (pessoa.SituacaoPessoa == SituacaoPessoaEnum.EmElaboracao)
                    modelo.SituacaoPessoaDescricao = "Em Elaboração";
                else if (pessoa.SituacaoPessoa == SituacaoPessoaEnum.Ativado)
                    modelo.SituacaoPessoaDescricao = "Ativado";
                else
                    modelo.SituacaoPessoaDescricao = "Desativado";

                return modelo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<PessoaViewModel> ListarPessoasIndex()
        {
            try
            {
                var pessoas = new List<PessoaViewModel>();
                var entidades = _pessoaService.Get();
                var portes = new Porte().Obter();

                foreach (var entidade in entidades)
                {
                    var modelo = new PessoaViewModel();

                    modelo.Id = entidade.Id;
                    modelo.CpfCnpj = entidade.TipoPessoaId == PESSOA_FISICA ? entidade.Cpf : entidade.Cnpj;
                    modelo.NomeRazaoSocial = entidade.TipoPessoaId == PESSOA_FISICA ? entidade.Nome : entidade.RazaoSocial;
                    modelo.TipoPessoa = entidade.TipoPessoaId == PESSOA_FISICA ? "Pessoa Física" : "Pessoa Júridica";
                    modelo.Nacional = entidade.Nacional == NacionalEnum.Sim ? "Sim" : "Não";
                    modelo.Porte = entidade.PorteId.HasValue ? portes.Where(p => p.Id == entidade.PorteId.Value).Select(s => s.Descricao).FirstOrDefault() : "N/A";
                    modelo.SituacaoPessoa = entidade.SituacaoPessoa;
                    modelo.PermiteExcluir = false;

                    if (entidade.SituacaoPessoa == SituacaoPessoaEnum.EmElaboracao)
                    { 
                        modelo.SituacaoPessoaDescricao = "Em Elaboração";
                        modelo.PermiteExcluir = true;
                    }
                    else if (entidade.SituacaoPessoa == SituacaoPessoaEnum.Ativado)
                        modelo.SituacaoPessoaDescricao = "Ativado";
                    else
                        modelo.SituacaoPessoaDescricao = "Desativado";

                    pessoas.Add(modelo);
                }

                return pessoas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult Index()
        {
            try
            {
                var pessoas = new PessoaViewModelIndex();
                
                pessoas.Pessoas = new List<PessoaViewModel>();
                pessoas.Pessoas = ListarPessoasIndex();

                return View(pessoas);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult Adicionar()
        {
            try
            {
                return View("Formulario", CarregarDadosCadastro(new PessoaFormularioViewModel() { SituacaoPessoa = SituacaoPessoaEnum.EmElaboracao, SituacaoPessoaDescricao = "Em Elaboração" }));
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
            try
            {
                var erro = string.Empty;
                var sucesso = GravarPessoa(model, atualizar: false, out erro);

                if(sucesso)
                { 
                    TempData["success"] = "Registro de pessoa salvo com sucesso.";

                    return RedirectToAction(btnSalvarContinuar != null ? "Adicionar" : "Index");
                }
                else
                {
                    TempData["warning"] = !string.IsNullOrEmpty(erro) ? erro : "Erro ao salvar registro.";

                    return View("Formulario", CarregarDadosCadastro(model));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult Alterar(Guid id)
        {
            try
            {
                var entidade = _pessoaService.Get(id);
                var modelo = new PessoaFormularioViewModel();

                if (entidade.TipoPessoaId == PESSOA_FISICA)
                    modelo = MontarModeloPessoaFisica(entidade);
                else
                    modelo = MontarModeloPessoaJuridica(entidade);

                return View("Formulario", CarregarDadosCadastro(modelo));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Alterar(PessoaFormularioViewModel model)
        {
            try
            {
                var erro = string.Empty;
                var sucesso = GravarPessoa(model, atualizar: true, out erro);

                if (sucesso)
                {
                    TempData["success"] = "Registro de pessoa salvo com sucesso.";

                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["warning"] = !string.IsNullOrEmpty(erro) ? erro : "Erro ao salvar registro.";

                    return View("Formulario", CarregarDadosCadastro(model));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult Desativar(Guid id)
        {
            try
            {
                var pessoa = _pessoaService.Get(id);

                pessoa.SituacaoPessoa = SituacaoPessoaEnum.Desativado;

                _pessoaService.Update(pessoa);

                TempData["success"] = "Registro desativado com sucesso!";

                return RedirectToAction("Index", "Pessoa");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult Ativar(Guid id)
        {
            try
            {
                var pessoa = _pessoaService.Get(id);

                pessoa.SituacaoPessoa = SituacaoPessoaEnum.Ativado;

                _pessoaService.Update(pessoa);

                TempData["success"] = "Registro ativado com sucesso!";

                return RedirectToAction("Index", "Pessoa");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult Excluir(Guid id, bool index)
        {
            try
            {
                _pessoaService.Remove(id);

                TempData["success"] = "Registro excluído com sucesso!";

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}