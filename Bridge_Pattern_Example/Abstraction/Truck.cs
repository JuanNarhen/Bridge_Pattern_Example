using Bridge_Pattern_Example.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern_Example.Abstraction
{
    public class Truck : Vehicle
    {
        public Truck(IEngine engine) : base(engine) { }

        public override void Travel()
        {
            Console.WriteLine("You have traveled in a truck.");
            base.Travel();
        }
    }
}
