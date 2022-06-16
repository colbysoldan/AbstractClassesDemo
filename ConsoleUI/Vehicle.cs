using System;
namespace ConsoleUI
{
	public abstract class Vehicle
	{
		public string Year { get; set; } = "year"; //default values
		public string Make { get; set; } = "make";
		public string Model { get; set; } = "model";

		public abstract void DriveAbstract(); //stubbed out method

		public virtual void DriveVirtual() //base implementation
        {
			Console.WriteLine("Drive");
        }

		public Vehicle()
		{
		}
	}
}

