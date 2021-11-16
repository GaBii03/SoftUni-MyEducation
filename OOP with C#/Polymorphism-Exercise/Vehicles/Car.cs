using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
	public class Car : Vehicle
	{
		public Car(double fuelQuantity, double fuelConsumptionInLitersPerKm, double tankCapacity)
			: base(fuelQuantity, fuelConsumptionInLitersPerKm, tankCapacity)
		{

		}

		public override double FuelConsumptionInLitersPerKm 
		{ 
			get => base.FuelConsumptionInLitersPerKm;
			set => base.FuelConsumptionInLitersPerKm = value + 0.9; 
		}
	}
}
