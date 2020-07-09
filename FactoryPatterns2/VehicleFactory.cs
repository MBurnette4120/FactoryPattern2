using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatterns2
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string userInput)
        {
            switch (userInput)
            {
                case "18":
                    return new BigRig();
                case "4":
                    return new Car();
                case "3":
                    return new ThreeWheeler();
                default:
                    return new Car();
            }






        }

        public static Vehicle GetAbtractVehicle(string userInput)
        { 

        
            switch (userInput)
            {

            case "2":
                return new Motorcycle();
            case "6":
                return new Bus();
            default:
                return new Bus();
            }

        }
    }
}

