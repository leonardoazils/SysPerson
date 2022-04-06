using System;
using System.Collections.Generic;

namespace SysPerson.Framework.Seeders
{
    public class TipoPessoa
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public List<TipoPessoa> Obter()
        {
            var registros = new List<TipoPessoa>();

            registros.Add(new TipoPessoa() { Id = 1, Descricao = "Física" });
            registros.Add(new TipoPessoa() { Id = 2, Descricao = "Júridica" });

            return registros;
        }
    }
}