using System;

namespace FactoryPatterns2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello!  Based on the amount of wheels you specify, we will build you a new vehicle!");
            Console.WriteLine($"How many wheels do you want your vehicle to have?");

            var userResponse = Console.ReadLine();

            var userVehicle = VehicleFactory.GetVehicle(userResponse);
            userVehicle.Drive();

            Console.WriteLine("Let's create an abstract vehicle.  How many wheels do you want?");
            var abstractInput = Console.ReadLine();

        }
    }
}
