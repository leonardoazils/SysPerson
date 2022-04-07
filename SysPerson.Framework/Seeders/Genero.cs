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

            registros.Add(new Genero() { Id = Guid.Parse("08736d98-5988-475b-9b2a-c3ed239c4b31"), Descricao = "Masculino" });
            registros.Add(new Genero() { Id = Guid.Parse("01829084-bc6d-4fe3-8421-bfe35ddd3b19"), Descricao = "Feminino" });
            registros.Add(new Genero() { Id = Guid.Parse("0d7bd349-8c1f-4c8d-8274-89b7fe73ae59"), Descricao = "Outros" });

            return registros;
        }
    }

}