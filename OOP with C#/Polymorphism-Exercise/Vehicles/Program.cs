using System;

namespace Vehicles
{
	public class Program
	{
		static void Main(string[] args)
		{
			string[] carInfo = Console.ReadLine().Split();
			string[] truckInfo = Console.ReadLine().Split();
			string[] busInfo = Console.ReadLine().Split();

			double carFuelQuantity = double.Parse(carInfo[1]);
			double carFuelConsumption = double.Parse(carInfo[2]);
			double carTankCapacity = double.Parse(carInfo[3]);

			double truckFuelQuantity = double.Parse(truckInfo[1]);
			double truckFuelConsumption = double.Parse(truckInfo[2]);
			double truckTankCapacity = double.Parse(truckInfo[3]);

			double busFuelQuantity = double.Parse(busInfo[1]);
			double busFuelConsumption = double.Parse(busInfo[2]);
			double busTankCapacity = double.Parse(busInfo[3]);

			IVehicle car = new Car(carFuelQuantity, carFuelConsumption, carTankCapacity);
			IVehicle truck = new Truck(truckFuelQuantity, truckFuelConsumption, truckTankCapacity);
			IVehicle bus = new Bus(busFuelQuantity, busFuelConsumption, busTankCapacity);

			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				string[] inputInfo = Console.ReadLine().Split();

				string action = inputInfo[0];
				string vehicle = inputInfo[1];

				if (action == "Drive")
				{
					double km = double.Parse(inputInfo[2]);

					if (vehicle == "Car")
					{
						if (car.CanDrive(km))
						{
							car.Drive(km);
							Console.WriteLine($"Car travelled {km} km");
						}
						else
						{
							Console.WriteLine("Car needs refueling");
						}

					}
					else if (vehicle == "Truck")
					{
						if (truck.CanDrive(km))
						{
							truck.Drive(km);
							Console.WriteLine($"Truck travelled {km} km");
						}
						else
						{
							Console.WriteLine("Truck needs refueling");
						}

					}
					else if (vehicle == "Bus")
					{
						bus.FuelConsumptionInLitersPerKm = busFuelConsumption + 1.4;
						if (bus.CanDrive(km))
						{
							bus.Drive(km);
							Console.WriteLine($"Bus travelled {km} km");
						}
						else
						{
							Console.WriteLine("Bus needs refueling");
						}
					}
				}
				else if (action == "Refuel")
				{
					double liters = double.Parse(inputInfo[2]);

					if (vehicle == "Car")
					{
						car.Refuel(liters);
					}
					else if (vehicle == "Truck")
					{
						truck.Refuel(liters);
					}
					else if (vehicle =="Bus")
					{
						bus.Refuel(liters);
					}
				}
				else if (action =="DriveEmpty")
				{
					double km = double.Parse(inputInfo[2]);

					if (bus.CanDrive(km))
					{
						bus.Drive(km);
						Console.WriteLine($"Bus travelled {km} km");
					}
					else
					{
						Console.WriteLine("Bus needs refueling");
					}
				}
			}

			Console.WriteLine($"Car: {car.FuelQuantity:f2}");
			Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
			Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
		}
	}
}
