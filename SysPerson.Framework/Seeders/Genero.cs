using System;
using System.Collections.Generic;

namespace SysPerson.Framework.Seeders
{
    public class Genero
    {
        public Guid Id { get; set; }

        public string Descricao { get; set; }

        public List<Genero> Obter() 
        {
            var registros = new List<Genero>();

            registros.Add(new Genero() { Id = Guid.NewGuid(), Descricao = "Masculino" });
            registros.Add(new Genero() { Id = Guid.NewGuid(), Descricao = "Feminino" });
            registros.Add(new Genero() { Id = Guid.NewGuid(), Descricao = "Outros" });

            return registros;
        }
    }

}