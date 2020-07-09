using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatterns2
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine($"This {GetType().Name} is really fast!");
        }
    }
}
