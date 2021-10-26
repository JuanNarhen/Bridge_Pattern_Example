using Bridge_Pattern_Example.Abstraction;
using Bridge_Pattern_Example.Implementation;
using System;

namespace Bridge_Pattern_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car(new Gasoline());
            car.Travel();
            car.AddFuel(10);

            Vehicle truck = new Truck(new Diesel());
            truck.Travel();
            truck.AddFuel(30);
        }
    }
}
