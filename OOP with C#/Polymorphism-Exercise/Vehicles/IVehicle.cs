using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
	public interface IVehicle
	{
		public double FuelQuantity { get; set; }
		public double FuelConsumptionInLitersPerKm { get; set; }
		public double TankCapacity { get; set; }

		public bool CanDrive(double km);

		public void Drive(double km);

		public void Refuel(double liters);

	}
}
