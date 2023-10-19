using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class Triangulo : Forma
    {
        public override void Draw()
        {
            Console.WriteLine("Desenhando o Triangulo!!");
            base.Draw();
        }
    }
}
