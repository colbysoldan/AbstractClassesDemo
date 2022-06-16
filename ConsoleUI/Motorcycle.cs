using System;
namespace ConsoleUI
{
	public class Motorcycle : Vehicle 
	{
		public Motorcycle()
		{
		}

        public bool HasSideCar { get; set; } = false;
        public bool IsManual { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine("The motorcycle is in drive.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcycle is in gear.");
        }
    }
}

