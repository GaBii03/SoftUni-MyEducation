using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Car
{
	class Engine
	{
		public Engine(int horsePower, double cubicCapacity)
		{
			HorsePower = horsePower;
			CubicCapacity = cubicCapacity;
		}
		public int HorsePower { get; set; }
		public double CubicCapacity { get; set; }
	}
}
