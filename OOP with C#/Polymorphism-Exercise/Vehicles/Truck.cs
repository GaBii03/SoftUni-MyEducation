using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
	public class Truck : Vehicle
	{
		public Truck(double fuelQuantity, double fuelConsumptionInLitersPerKm, double tankCapacity)
			: base(fuelQuantity, fuelConsumptionInLitersPerKm, tankCapacity)
		{

		}

		public override double FuelConsumptionInLitersPerKm 
		{ 
			get => base.FuelConsumptionInLitersPerKm;
			set => base.FuelConsumptionInLitersPerKm = value + 1.6; 
		}

		public override void Refuel(double liters)
		{
			if (liters <= 0)
			{
				Console.WriteLine($"Fuel must be a positive number");

			}
			else if (FuelQuantity + liters > TankCapacity)
			{
				Console.WriteLine($"Cannot fit {liters} fuel in the tank");
			}
			else
			{
				FuelQuantity += liters*0.95;
			}
		}
	}
}
