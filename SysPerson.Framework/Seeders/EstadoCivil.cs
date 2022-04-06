using System;
using System.Collections.Generic;

namespace SysPerson.Framework.Seeders
{
    public class EstadoCivil
    {
        public Guid Id { get; set; }

        public string Descricao { get; set; }

        public List<EstadoCivil> Obter()
        {
            var registros = new List<EstadoCivil>();

            registros.Add(new EstadoCivil() { Id = Guid.NewGuid(), Descricao = "Casado(a)" });
            registros.Add(new EstadoCivil() { Id = Guid.NewGuid(), Descricao = "Solteiro(a)" });
            registros.Add(new EstadoCivil() { Id = Guid.NewGuid(), Descricao = "Divorciado(a)" });
            registros.Add(new EstadoCivil() { Id = Guid.NewGuid(), Descricao = "Viuvo(a)" });
            registros.Add(new EstadoCivil() { Id = Guid.NewGuid(), Descricao = "Outros" });

            return registros;
        }
    }
}