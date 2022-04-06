using System;
using System.Collections.Generic;

namespace SysPerson.Framework.Seeders
{
    public class Porte
    {
        public Guid Id { get; set; }

        public string Descricao { get; set; }

        public List<Porte> Obter()
        {
            var registros = new List<Porte>();

            registros.Add(new Porte() { Id = Guid.NewGuid(), Descricao = "Pequeno" });
            registros.Add(new Porte() { Id = Guid.NewGuid(), Descricao = "Médio" });
            registros.Add(new Porte() { Id = Guid.NewGuid(), Descricao = "Grande" });
            registros.Add(new Porte() { Id = Guid.NewGuid(), Descricao = "Outros" });

            return registros;
        }
    }
}