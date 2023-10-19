using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class Carro : Veiculo
    {
        public Carro()
        {
            Console.WriteLine("Eu sou um carro");
        }

        public override void Acelerar()
        {
            Console.WriteLine("Estou acelerando.");

        }

        public override void Freiar()
        {
            Console.WriteLine("Estou freiando.");
        }

        public override void Ligar()
        {
            MotorPartidaAcinado = true;
            InjetadoCombustivel = true;
            MotorLigado = true;
            Console.WriteLine("O carro está ligado");
        }
    }
}
