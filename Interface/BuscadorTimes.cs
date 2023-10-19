using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    public class BuscadorTimes : IBuscador
    {
        public List<string> GetResultado(string criterio)
        {
            var times = new List<string> { "Santos", "Palmeiras", "Vasco", "Coritiba", "Bahia" };


            var resultado = times.Where(e => e.Contains(criterio)).ToList();
            return resultado;
        }
    }
}
