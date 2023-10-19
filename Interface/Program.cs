using System;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var dicionario = new Dicionario("a");
            //var retornos = dicionario.Procurar("");
            //var retornos = dicionario.Procurar("TIM");
            //var retornos = dicionario.Procurar("FRU");
            var retornos = dicionario.Procurar("COR");

            foreach (var item in retornos) {

                Console.WriteLine($"Retorno da busca!: {item}");
            }

            Console.ReadKey();
        }
    }
}
