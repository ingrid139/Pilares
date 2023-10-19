using System;

namespace Henranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Mundo Animal!");

            Animal animal = new Animal();
            animal.Reino();

            Console.WriteLine("");
            Console.WriteLine("Hello World Herança! Mamifero");
            Mamifero mamifero = new Mamifero();
            mamifero.Reino();
            mamifero.Grupos();

            Console.WriteLine("");
            Console.WriteLine("Hello World Herança! Aves");
            Aves aves = new Aves();
            aves.Reino();
            aves.Corporal();

            Console.WriteLine("");
            Console.WriteLine("Hello World Multinivel! Homem");
            Homem homem = new Homem();
            homem.Reino();
            homem.Grupos();
            homem.Sensorial();

            Console.WriteLine("");
            Console.WriteLine("Hello World Multinivel! Beija-Flor");
            BeijaFlor beijaflor = new BeijaFlor();
            beijaflor.Reino();
            beijaflor.Corporal();
            beijaflor.Bico();

            Console.ReadKey();

        }
    }
}
