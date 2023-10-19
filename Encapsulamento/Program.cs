using System;

namespace Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Encapsulamento");

            Veiculo veiculo = new Carro();
            veiculo.Ligar();
            veiculo.Acelerar();
            veiculo.Freiar();

            Console.ReadKey();

        }
    }
}
