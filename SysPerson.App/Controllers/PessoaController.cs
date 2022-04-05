﻿using SysPerson.App.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SysPerson.App.Controllers
{
    public class PessoaController : Controller
    {
        public ActionResult Index()
        {
            var listaPessoas = new PessoaViewModelIndex();
            var pessoas = new List<PessoaViewModel>();

            var pessoa1 = new PessoaViewModel();

            pessoa1.Id = 1;
            pessoa1.CpfCnpj = "085.891.079-90";
            pessoa1.NomeRazaoSocial = "Leonardo Augusto Zils";
            pessoa1.TipoPessoa = "Pessoa Física";
            pessoa1.Nacional = "Sim";
            pessoa1.Porte = "OUTROS";
            pessoa1.Ativo = true;
            pessoa1.PermiteExcluir = true;

            pessoas.Add(pessoa1);

            var pessoa2 = new PessoaViewModel();

            pessoa2.Id = 2;
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
                var pessoa = new PessoaViewModel();

                pessoa.Id = 1;
                pessoa.CpfCnpj = "085.891.079-90";
                pessoa.NomeRazaoSocial = "Leonardo Augusto Zils";
                pessoa.TipoPessoa = "Pessoa Física";
                pessoa.Nacional = "Sim";
                pessoa.Porte = "OUTROS";
                pessoa.Ativo = true;
                pessoa.PermiteExcluir = true;

                return View("Formulario", pessoa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}