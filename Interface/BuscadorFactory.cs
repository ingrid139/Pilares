using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public class BuscadorFactory
    {
        private string TIM = "TIM";
        private string FRU = "FRU";
        private string COR = "COR";

        public IBuscador getBuscadorInicio(string tipo)
        {
            var resultados = new List<string>();
            if (TIM.Equals(tipo))
            {
                return new BuscadorTimes();
            }
            else if (FRU.Equals(tipo))
            {
                return new BuscadorFrutas();
            }
            else
            {
                return new Buscador();
            }
        }

        public IBuscador getBuscador(string tipo)
        {
            switch (tipo)
            {
                case "TIM":
                    return new BuscadorTimes();
                case "FRU":
                    return new BuscadorFrutas();
                case "COR":
                    return new BuscadorCores();
                default:
                    return new Buscador();
            }
        }
    }
}
