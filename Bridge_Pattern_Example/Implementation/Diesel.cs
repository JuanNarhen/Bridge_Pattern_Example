using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern_Example.Implementation
{
    public class Diesel : IEngine
    {
        public void AddFuel(double quantity)
        {
            Console.WriteLine($"Added {quantity} gal of diesel");
        }

        public void EmptyFuel()
        {
            Console.WriteLine("Empty tank of diesel");
        }
    }
}
