using System;
using System.Collections.Generic;

namespace SysPerson.Framework.Seeders
{
    public class CaracterizacaoCapital
    {
        public Guid Id { get; set; }

        public string Descricao { get; set; }

        public List<CaracterizacaoCapital> Obter()
        {
            var registros = new List<CaracterizacaoCapital>();

            registros.Add(new CaracterizacaoCapital() { Id = Guid.NewGuid(), Descricao = "Registro Exemplo" });
            registros.Add(new CaracterizacaoCapital() { Id = Guid.NewGuid(), Descricao = "Outros" });

            return registros;
        }
    }
}