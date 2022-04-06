using System;
using System.Collections.Generic;

namespace SysPerson.Framework.Seeders
{
    public class TipoPessoa
    {
        public Guid Id { get; set; }

        public string Descricao { get; set; }

        public List<TipoPessoa> Obter()
        {
            var registros = new List<TipoPessoa>();

            registros.Add(new TipoPessoa() { Id = Guid.NewGuid(), Descricao = "Física" });
            registros.Add(new TipoPessoa() { Id = Guid.NewGuid(), Descricao = "Júridica" });

            return registros;
        }
    }
}