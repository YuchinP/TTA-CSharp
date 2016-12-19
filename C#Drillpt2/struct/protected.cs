using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Protected and Protected Internal Access Modifiers




namespace @struct
{
    class Protect
    {
        protected int x;
        protected internal int y;
    }

    class Derivation : Protect
    {
        static void Main()
        {
            Derivation d = new Derivation();

            d.x = 10;
            d.y = 15;
            Console.WriteLine("x = {0}, y = {1}", d.x, d.y);
        }
    }
    
}