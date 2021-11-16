using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Car
{
	class Car
	{
		string make;
		string model;
		int year;
		double fuelQuantity;
		double fuelConsumption;

		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public double FuelQuantity { get; set; }
		public double FuelConsumption { get; set; }
		public Engine Engine { get; set; }
		public Tire[] Tires { get; set; }

		public Car()
		{
			Make = "VW";
			Model = "Golf";
			Year = 2025;
			FuelQuantity = 200;
			FuelConsumption = 10;
		}

		public Car(string make, string model, int year)
		{
			this.Make = make;
			this.Model = model;
			this.Year = year;
		}

		public Car(string make, string model,
			int year, double fuelQuantity,
			double fuelConsumption, Engine engine,
			Tire[] tires) : this(make, model, year)
		{
			this.FuelQuantity = fuelQuantity;
			this.FuelConsumption = fuelConsumption;
			Engine = engine;
			Tires = tires;
		}

		public void Drive(double distance)
		{
			var consumption = distance * (FuelConsumption / 100.0);
			if (consumption <= FuelQuantity)
			{
				FuelQuantity -= consumption;
			}
			else
			{
				Console.WriteLine("Not enough fuel to perform this trip!");
			}
		}

		public string WhoAmI()
		{
			return $"Make :{Make}\nModel: {Model}\nYear: {Year}\nFuelQuantity: {FuelQuantity:f2}";
		}
	}
}
