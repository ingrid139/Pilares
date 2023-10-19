using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    public class BuscadorCores : IBuscador
    {
        public List<string> GetResultado(string criterio)
        {
            var itens = new List<string> { "Azul","Branco", "Preto", "Amarelo", "Verde","Vermelho" };

            var resultado = itens.Where(e => e.Contains(criterio)).ToList();
            return resultado;
        }
    }
}
