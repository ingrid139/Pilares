using System;
using System.Collections.Generic;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Forma");
            Imprimir();
            ImprimirTodasFormas();

            Console.ReadKey();

        }

        public static void Imprimir()
        {
            Console.WriteLine("IMPRIMIR | INICIO");

            Forma forma = new Forma();
            forma.Draw();


            Console.WriteLine("");
            Console.WriteLine("_____CIRCULO_____");
            Circulo circulo = new Circulo(1);
            circulo.Draw();

            Console.WriteLine("");
            Console.WriteLine("_____RETANGULO_____");
            Retangulo retangulo = new Retangulo();
            retangulo.Draw();
            Console.WriteLine("IMPRIMIR | FINAL");

        }

        public static void ImprimirTodasFormas()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("IMPRIMIR TODAS| INICIO");
            var formas = new List<Forma>
            {
                new Circulo(1),
                new Retangulo(),
                new Triangulo()
            };

            foreach (var forma in formas)
            {
                forma.Draw();
            }

            Console.WriteLine("IMPRIMIR TODAS| FINAL");

        }
    }
}
