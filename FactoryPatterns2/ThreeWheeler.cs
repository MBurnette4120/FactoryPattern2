using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatterns2 
{
    public class ThreeWheeler : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine($"Your {GetType().Name} is ready to roll!");
        }
    }
}
