using Bridge_Pattern_Example.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern_Example.Abstraction
{
    public class Vehicle
    {
        protected IEngine Engine { get; set; }

        public Vehicle(IEngine engine)
        {
            this.Engine = engine;
        }

        public void AddFuel(double value)
        {
            this.Engine.AddFuel(value);
        }

        public virtual void Travel()
        {
            this.Engine.EmptyFuel();
        }
    }
}
