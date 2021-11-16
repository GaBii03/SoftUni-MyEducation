using System;

namespace _01.ConvertMetersToKilometers
{
	class Program
	{
		static void Main(string[] args)
		{
			int meters = int.Parse(Console.ReadLine());
			decimal kilomitars = meters / 1000M;
			Console.WriteLine($"{kilomitars:f2}");
		}
	}
}
