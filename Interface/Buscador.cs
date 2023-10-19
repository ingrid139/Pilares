using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    public class Buscador : IBuscador
    {
        public List<string> GetResultado(string criterio)
        {
            var itens = new List<string> { "Futebol", "Voleibol",
                                       "Basquetebol", "Natação", "Rugby", "Handebol", "Esgrima",
                        "Maria","Carla","Paulo","Fernanda","Carlos","Amanda","Haroldo"
                                };

            var resultado = itens.Where(e => e.Contains(criterio)).ToList();
            return resultado;
        }
    }
}
