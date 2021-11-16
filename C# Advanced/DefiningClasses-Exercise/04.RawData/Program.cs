using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.RawData
{
	public class Program
	{
		public static void Main(string[] args)
		{
			List<Car> cars = new List<Car>();
			int n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				string[] infoCar = Console.ReadLine().Split();
				string model = infoCar[0];
				int engineSpeed = int.Parse(infoCar[1]);
				int enginePower = int.Parse(infoCar[2]);
				int cargoWeight = int.Parse(infoCar[3]);
				string cargoType = infoCar[4];

				List<Tire> tires = new List<Tire>();
		
				for (int j = 5; j <= 12; j+=2)
				{
					double tirePressure = double.Parse(infoCar[j]);
					int tireAge = int.Parse(infoCar[j + 1]);
					Tire tire = new Tire(tirePressure, tireAge);
					tires.Add(tire);
				}

				Engine engine = new Engine(engineSpeed, enginePower);
				Cargo cargo = new Cargo(cargoType, cargoWeight);
				Car car = new Car(model, engine, cargo, tires);
				cars.Add(car);
			}

			string commandCargoType = Console.ReadLine();
			if (commandCargoType == "fragile")
			{
				List<Car> frigileCars = cars
					.Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(t => t.Pressure < 1))
					.ToList();

				foreach (var item in frigileCars)
				{
					Console.WriteLine(item.Model);
				}
			}
			else
			{
				List<Car> flammableCars = cars
					.Where(x => x.Cargo.Type == "flammable" && x.Engine.Power>250)
					.ToList();

				foreach (var item in flammableCars)
				{
					Console.WriteLine(item.Model);
				}
			}
		}
	}
}
