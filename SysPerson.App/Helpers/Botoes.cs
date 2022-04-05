using System;
using System.Web.Mvc;

namespace SysPerson.App.Helpers
{
    public static class Botoes
    {
        public static MvcHtmlString Salvar(this HtmlHelper helper)
        {
            return MvcHtmlString.Create("<button type='submit' for='saveb' class='btn btn-lg bg-teal waves-effect waves-float' >SALVAR</ button>");
        }

        public static MvcHtmlString SalvarNovo(this HtmlHelper helper)
        {
            return MvcHtmlString.Create("<button name='btnSalvarContinuar' value='continuar' type='submit' class='btn btn-lg bg-light-blue waves-effect waves-float'>SALVAR E NOVO</button>");
        }

        public static MvcHtmlString Informacoes(this HtmlHelper helper)
        {
            return MvcHtmlString.Create("<button type='button' data-toggle='modal' data-target='#defaultModal' class='btn btn-lg bg-brown waves-effect waves-float'>INFORMAÇÕES</button>");
        }

        public static MvcHtmlString Adicionar(this HtmlHelper helper, string url, bool insercaoBloqueada = false)
        {
            return MvcHtmlString.Create($"<a href={url} {(insercaoBloqueada ? "disabled" : "")} class='btn btn-lg bg-teal waves-effect waves-float'>ADICIONAR</a>");
        }

        public static MvcHtmlString Excluir(this HtmlHelper helper, string url)
        {
            return MvcHtmlString.Create($"<a href={url} class='btn btn-lg btn-danger waves-effect waves-float'>EXCLUIR</a>");
        }

        public static MvcHtmlString Voltar(this HtmlHelper helper, string url)
        {
            return MvcHtmlString.Create(String.Format("<a href={0} class='btn bg-red btn-circle waves-effect waves-circle waves-float' data-toggle='tooltip' data-placement='right' title='Voltar'><i class='material-icons'>keyboard_backspace</i></a>", url));
        }
    }
}