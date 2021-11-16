using System;
using System.Collections.Generic;

namespace _03.SpeedRacing
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//Dictionary<string, double[]> cars = new Dictionary<string, double[]>();
			int n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				string[] info = Console.ReadLine().Split();
				string model = info[0];
				double fuelAmount = double.Parse(info[1]);
				double fuelConsumptionPerKilometer = double.Parse(info[2]);
				Car currCar = new Car(model, fuelAmount, fuelConsumptionPerKilometer);
				double[] infoMassive = { fuelAmount, fuelConsumptionPerKilometer };
				//cars.Add(model, infoMassive);
			}

			string command = Console.ReadLine();
			while (command != "End")
			{
				string[] commandArr = command.Split();
				string carModel = commandArr[1];
				double amountOfKm = double.Parse(commandArr[2]);

				command = Console.ReadLine();
			}

			//foreach (var car in cars)
			//{
			//	Console.WriteLine($"{car.Key} {car.Value[0]} {car.Value[1]}");
			//}
		}
	}
}
