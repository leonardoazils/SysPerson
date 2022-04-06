using System;
using System.Collections.Generic;

namespace SysPerson.Framework.Seeders
{
    public class TipoEmpresa
    {
        public Guid Id { get; set; }

        public string Descricao { get; set; }

        public List<TipoEmpresa> Obter()
        {
            var registros = new List<TipoEmpresa>();

            registros.Add(new TipoEmpresa() { Id = Guid.NewGuid(), Descricao = "Leiloeiro(a)" });
            registros.Add(new TipoEmpresa() { Id = Guid.NewGuid(), Descricao = "Alimentação" });
            registros.Add(new TipoEmpresa() { Id = Guid.NewGuid(), Descricao = "Saúde" });
            registros.Add(new TipoEmpresa() { Id = Guid.NewGuid(), Descricao = "Outros" });

            return registros;
        }
    }
}