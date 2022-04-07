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

            registros.Add(new EstadoCivil() { Id = Guid.Parse("d7b57900-b031-46b9-bf67-cf048f5a5e68"), Descricao = "Casado(a)" });
            registros.Add(new EstadoCivil() { Id = Guid.Parse("64fbdd86-b8b8-4036-8330-fce29edbfb67"), Descricao = "Solteiro(a)" });
            registros.Add(new EstadoCivil() { Id = Guid.Parse("8e113f86-365e-482e-b7cd-4ae5d6740980"), Descricao = "Divorciado(a)" });
            registros.Add(new EstadoCivil() { Id = Guid.Parse("10b2ef31-f181-4a2c-bb93-65dc82b78e44"), Descricao = "Viuvo(a)" });
            registros.Add(new EstadoCivil() { Id = Guid.Parse("708029c3-8cfb-4580-a51e-18df135a5a02"), Descricao = "Outros" });

            return registros;
        }
    }
}