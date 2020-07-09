using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatterns2
{
    public class Bus : Vehicle
    {

        public Bus() 
        {
        }

        public override void Drive()
        {
            Console.WriteLine($"Your {GetType()} is ready!!");
        }
    }
}
