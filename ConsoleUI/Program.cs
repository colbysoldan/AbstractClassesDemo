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
             * Create an abstract class called Vehicle - DONE
             * The vehicle class shall have three string properties Year, Make, and Model - DONE
             * Set the defaults to something generic in the Vehicle class - DONE
             * Vehicle shall have an abstract method called DriveAbstract with no implementation - DONE
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation. - DONE
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle - DONE
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle - DONE
             * Provide the implementations for the abstract methods - DONE
             * Only in the Motorcycle class will you override the virtual drive method - DONE
            */

            // Create a list of Vehicles called vehicles
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes - DONE
             * - set it up as one of each derived class - DONE
             * Set the properties with object initializer syntax - Done
             */

            Car impala = new Car() { FourDoor = true, Make = "Chevrolet", Model = "Impala", Year = "2020" };
            Motorcycle scrambler = new Motorcycle() {Make = "Triumph", Model = "Scrambler", Year = "2022" };

            Vehicle explorer = new Car() {FourDoor = true, Make = "Ford", Model = "Ford", Year = "2002" };
            Vehicle tuano = new Motorcycle() { HasSideCar = true, IsManual = false, Make = "Aprilla", Model = "Tuano", Year = "2019" };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(impala);
            vehicles.Add(scrambler);
            vehicles.Add(explorer);
            vehicles.Add(tuano);
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Make: {vehicle.Make}" +
                    $"\nModel: {vehicle.Model}" +
                    $"\nYear: {vehicle.Year}");
                vehicle.DriveAbstract();
                Console.WriteLine();
            }

            // Call each of the drive methods for one car and one motorcycle

            impala.DriveAbstract();
            tuano.DriveAbstract();
            explorer.DriveVirtual();
            scrambler.DriveVirtual();

            #endregion            
            Console.ReadLine();
        }
    }
}
