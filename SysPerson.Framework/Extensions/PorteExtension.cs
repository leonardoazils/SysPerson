﻿using SysPerson.Framework.Seeders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SysPerson.Framework.Extensions
{
    public static class PorteExtension
    {
        public static IEnumerable<SelectListItem> DropDownList(this IEnumerable<Porte> listaEntidades)
        {
            return listaEntidades.OrderBy(x => x.Descricao).Select(x => new SelectListItem { Text = x.Descricao, Value = x.Id.ToString() });
        }

        public static IEnumerable<SelectListItem> DropDownList(this IEnumerable<Porte> listaEntidades, Guid idSelecionado)
        {
            return listaEntidades.OrderBy(x => x.Descricao).Select(x => new SelectListItem { Text = x.Descricao, Value = x.Id.ToString(), Selected = x.Id.Equals(idSelecionado) });
        }
    }
}
