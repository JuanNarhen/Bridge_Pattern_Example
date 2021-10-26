using Bridge_Pattern_Example.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern_Example.Abstraction
{
    public class Car:Vehicle
    {
        public Car(IEngine engine) : base(engine) { }

        public override void Travel()
        {
            Console.WriteLine("You have traveled in a car");
            base.Travel();
        }
    }
}
