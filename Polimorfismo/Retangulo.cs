using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class Retangulo : Forma
    {
        public override void Draw()
        {
            Console.WriteLine("Desenhando o retangulo!!");
            base.Draw();
        }
    }
}
