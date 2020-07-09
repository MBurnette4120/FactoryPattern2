using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatterns2
{
    public class BigRig : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine($"Your {GetType().Name} is rocking and rolling!");
        }
    }
}
