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

            registros.Add(new CaracterizacaoCapital() { Id = Guid.Parse("a342a92d-c67c-4fbf-bce6-cb8f401771dc"), Descricao = "Registro Exemplo" });
            registros.Add(new CaracterizacaoCapital() { Id = Guid.Parse("32917481-7e7e-4376-8695-54695dce6fbd"), Descricao = "Outros" });

            return registros;
        }
    }
}