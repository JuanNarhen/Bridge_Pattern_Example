using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern_Example.Implementation
{
    public interface IEngine
    {
        public void AddFuel(double quantity);
        public void EmptyFuel();
    }
}
