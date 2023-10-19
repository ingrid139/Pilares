using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public abstract class Veiculo
    {
        protected bool MotorLigado;
        protected bool MotorPartidaAcinado;
        protected bool InjetadoCombustivel;

        public Veiculo()
        {
            Console.WriteLine("Eu sou um veículo");
        }

        public abstract void Ligar();

        public abstract void Acelerar();

        public abstract void Freiar();
    }
}
