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

            registros.Add(new Porte() { Id = Guid.Parse("df15f6d0-6dd9-49fb-a8e9-fa12a1c41d8d"), Descricao = "Pequeno" });
            registros.Add(new Porte() { Id = Guid.Parse("f1d484c6-8e5a-40d0-9c9e-9ad2212daf41"), Descricao = "Médio" });
            registros.Add(new Porte() { Id = Guid.Parse("cb047cb8-e6f4-4a2d-92c0-2905f3894fd9"), Descricao = "Grande" });
            registros.Add(new Porte() { Id = Guid.Parse("52c3d4b9-d53a-468d-be61-e8e541685f92"), Descricao = "Outros" });

            return registros;
        }
    }
}