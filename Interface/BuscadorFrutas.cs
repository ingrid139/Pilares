using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    public class BuscadorFrutas : IBuscador
    {
        public List<string> GetResultado(string criterio)
        {
            var itens = new List<string> { "Melancia", "Laranja", "Abacate", "Banana", "Uva", "Mexerica", "Manga" };

            var resultado = itens.Where(e => e.Contains(criterio)).ToList();
            return resultado;
        }
    }
}
