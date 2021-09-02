using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            // Done

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Done

            // Create a list of Vehicle called vehicles

            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            vehicles.Add(new Car()
            {
                Year = 1994,
                HasTrunk = false, 
                Make = "Car",
                Model = "type Car"
            });

            vehicles.Add(new Motorcycle()
            {
                Year = 1995,
                HasSideCart = false,
                Make = "Motorcycle",
                Model = "type Motorcycle"
            });

            Vehicle carVehicle = new Car()
            {
                Year = 1996,
                HasTrunk = true,
                Make = "Car",
                Model = "type Vehicle"
            };

            Vehicle motorcycleVehicle = new Motorcycle()
            {
                Year = 1997,
                HasSideCart = true,
                Make = "Motorcycle",
                Model = "type vehicle"
            };

            vehicles.Add(carVehicle);
            vehicles.Add(motorcycleVehicle);

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine("\n***************************");
                Console.WriteLine($"Vehicle at index {vehicles.IndexOf(vehicle)}: ");
                Console.WriteLine($"Year: {vehicle.Year}\nMake: {vehicle.Make}\nModel: {vehicle.Model}");
                Console.WriteLine();
            }

            Console.ReadLine();
            // Call each of the drive methods for one car and one motorcycle

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine("\n***************************");
                Console.WriteLine($"Vehicle at index {vehicles.IndexOf(vehicle)}: ");
                Console.WriteLine("DriveAbstract: ");
                vehicle.DriveAbstract();
                Console.WriteLine("DriveVirtual:");
                vehicle.DriveVirtual();
                Console.WriteLine();

            }

            #endregion            
            Console.ReadLine();
        }
    }
}
