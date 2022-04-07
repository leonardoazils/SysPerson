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

            registros.Add(new TipoEmpresaPj() { Id = Guid.Parse("82181324-3004-43a5-8ecc-8691191afdca"), Descricao = "LTDA - LIMITADA" });
            registros.Add(new TipoEmpresaPj() { Id = Guid.Parse("60c0fd61-ae88-4285-86c7-1c4b2c4ea111"), Descricao = "MEI" });
            registros.Add(new TipoEmpresaPj() { Id = Guid.Parse("3fa5fc52-4c2d-4466-a56e-c81fdc03bad5"), Descricao = "SIMPLES" });
            registros.Add(new TipoEmpresaPj() { Id = Guid.Parse("3aeb68a5-2b82-4309-9f69-b1b94734effc"), Descricao = "OUTROS" });

            return registros;
        }
    }
}