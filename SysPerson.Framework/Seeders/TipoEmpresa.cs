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

            registros.Add(new TipoEmpresa() { Id = Guid.Parse("c24a78e6-a219-4192-bffd-5dfe15d70a05"), Descricao = "Leiloeiro(a)" });
            registros.Add(new TipoEmpresa() { Id = Guid.Parse("44d3f221-c1b2-4f9c-9f10-241b8509e946"), Descricao = "Alimentação" });
            registros.Add(new TipoEmpresa() { Id = Guid.Parse("13407663-00cf-4110-9231-3773b0a001f6"), Descricao = "Saúde" });
            registros.Add(new TipoEmpresa() { Id = Guid.Parse("4ce4964e-d032-4edd-95e3-8d182b65f873"), Descricao = "Outros" });

            return registros;
        }
    }
}