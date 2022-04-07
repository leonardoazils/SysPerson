using SysPerson.Framework.Seeders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SysPerson.Framework.Extensions
{
    public static class TipoEmpresaPjExtension
    {
        public static IEnumerable<SelectListItem> DropDownList(this IEnumerable<TipoEmpresaPj> listaEntidades)
        {
            return listaEntidades.OrderBy(x => x.Descricao).Select(x => new SelectListItem { Text = x.Descricao, Value = x.Id.ToString() });
        }

        public static IEnumerable<SelectListItem> DropDownList(this IEnumerable<TipoEmpresaPj> listaEntidades, Guid idSelecionado)
        {
            return listaEntidades.OrderBy(x => x.Descricao).Select(x => new SelectListItem { Text = x.Descricao, Value = x.Id.ToString(), Selected = x.Id.Equals(idSelecionado) });
        }
    }
}
