using _01.Car;
using System;

namespace CarManufacturer
{
	class StartUp
	{
		static void Main(string[] args)
		{
			string make = Console.ReadLine();
			string model = Console.ReadLine();
			int year = int.Parse(Console.ReadLine());
			double fuelQuantity = double.Parse(Console.ReadLine());
			double fuelConsumption = double.Parse(Console.ReadLine());

			Engine engine = new Engine(300, 3000);
			Tire[] tires = new Tire[]
			{
				new Tire(2021, 2.8),
				new Tire(2021, 2.8),
				new Tire(2020, 2.6),
				new Tire(2020, 2.6)

			};

			Car firstCar = new Car();
			Car secondCar = new Car(make, model, year);
			Car thirdCar = new Car(make, model, year, fuelConsumption, fuelQuantity, engine, tires);
			Console.WriteLine(firstCar.WhoAmI());
			Console.WriteLine(thirdCar.WhoAmI());
			
		}
	}
}
