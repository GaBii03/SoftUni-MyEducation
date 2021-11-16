using System;
using System.Collections.Generic;
using System.Text;

namespace _03.SpeedRacing
{
	public class Car
	{
		public string Model { get; set; }
		public double FuelAmount { get; set; }
		public double FuelConsumptionPerKilometer { get; set; }
		public double TravelledDistance { get; set; }

		public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
		{
			Model = model;
			FuelAmount = fuelAmount;
			FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
		}
	}
}
