using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class Forma
    {
        // A few example members
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }
        
        public Forma(int x)
        {
            X = x;
        }
        public Forma()
        {
            
        }

        // Virtual method
        public virtual void Draw()
        {
            Console.WriteLine("Desenhando a forma!!");
        }
    }
}
