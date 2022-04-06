using System;
using System.Collections.Generic;

namespace SysPerson.Framework.Seeders
{
    public class TipoEmpresaPj
    {
        public Guid Id { get; set; }

        public string Descricao { get; set; }

        public List<TipoEmpresaPj> Obter()
        {
            var registros = new List<TipoEmpresaPj>();

            registros.Add(new TipoEmpresaPj() { Id = Guid.NewGuid(), Descricao = "LTDA - LIMITADA" });
            registros.Add(new TipoEmpresaPj() { Id = Guid.NewGuid(), Descricao = "MEI" });
            registros.Add(new TipoEmpresaPj() { Id = Guid.NewGuid(), Descricao = "SIMPLES" });
            registros.Add(new TipoEmpresaPj() { Id = Guid.NewGuid(), Descricao = "OUTROS" });

            return registros;
        }
    }
}