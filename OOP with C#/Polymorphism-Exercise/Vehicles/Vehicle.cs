using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
	public abstract class Vehicle : IVehicle
	{
		private double fuelQuantity;
		private double fuelConsumptionInLitersPerKm;
		private double tankCapacity;

		protected Vehicle(double fuelQuantity, double fuelConsumptionInLitersPerKm, double tankCapacity)
		{
			FuelQuantity = fuelQuantity;
			FuelConsumptionInLitersPerKm = fuelConsumptionInLitersPerKm;
			TankCapacity = tankCapacity;

			if (fuelQuantity> tankCapacity)
			{
				FuelQuantity = 0;
			}
		}

		public double TankCapacity
		{
			get => tankCapacity;
			set => tankCapacity = value;
		}

		public double FuelQuantity
		{
			get => fuelQuantity;
			set => fuelQuantity = value;
		}

		public virtual double FuelConsumptionInLitersPerKm
		{
			get => fuelConsumptionInLitersPerKm;
			set => fuelConsumptionInLitersPerKm = value;
		}

		public bool CanDrive(double km)
		{
			if (km* fuelConsumptionInLitersPerKm <= FuelQuantity)
			{
				return true;
			}
			return false;
		}

		public void Drive(double km)
		{
			if (FuelQuantity - km * fuelConsumptionInLitersPerKm <= FuelQuantity)
			{
				
			}
			FuelQuantity -= km * fuelConsumptionInLitersPerKm;
		}

		public virtual void Refuel(double liters)
		{
			if (liters<=0)
			{
				Console.WriteLine($"Fuel must be a positive number");
				
			}
			else if (FuelQuantity + liters > TankCapacity)
			{
				Console.WriteLine($"Cannot fit {liters} fuel in the tank");
			}
			else
			{
				FuelQuantity += liters;
			}

		}
	}
}
