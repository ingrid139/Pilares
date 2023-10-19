using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class Circulo : Forma
    {
        public Circulo(int x) : base(x)
        {
            
        }
        public override void Draw()
        {
            Console.WriteLine("Desenhando o circulo!!");
            base.Draw();
        }
    }
}
