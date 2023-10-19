using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public class Dicionario
    {
        public Dicionario(string _criterio)
        {
            criterio = _criterio;
        }
        private string criterio;
        private string TIM = "TIM";
        private string FRU = "FRU";
        public List<string> ProcurarInicio(string tipo)
        {
            var resultados = new List<string>();
            BuscadorFactory factory = new BuscadorFactory();
            if (TIM.Equals(tipo))
            {
                IBuscador procura = factory.getBuscador(tipo);

                resultados.AddRange(procura.GetResultado(criterio));
            }
            else if (FRU.Equals(tipo))
            {
                IBuscador procura = factory.getBuscador(tipo);

                resultados.AddRange(procura.GetResultado(criterio));
            }
            else
            {
                IBuscador procura = new Buscador();
                resultados.AddRange(procura.GetResultado(criterio));
            }
            
            return resultados;
        }

        public List<string> Procurar(string tipo)
        {
            BuscadorFactory factory = new BuscadorFactory();
            IBuscador procura = factory.getBuscador(tipo);

            return procura.GetResultado(criterio);
        }
    }
}
