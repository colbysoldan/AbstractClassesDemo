using System;
namespace ConsoleUI
{
	public class Car : Vehicle
	{
		public Car()
		{
		}

        public bool HasTrunk { get; set; } = true;
        public bool FourDoor { get; set; } = false;

        public override void DriveAbstract() //required implementation
        {
            Console.WriteLine("The car is in drive.");
        }
    }
}

