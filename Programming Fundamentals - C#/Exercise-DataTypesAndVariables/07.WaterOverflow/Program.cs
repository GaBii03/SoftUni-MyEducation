using System;

namespace _07.WaterOverflow
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			const int capacity = 255;
			int pouredWater = 0;
			for (int i = 1; i <= n; i++)
			{
				int litters = int.Parse(Console.ReadLine());
				pouredWater += litters;
				if (pouredWater>capacity)
				{
					Console.WriteLine("Insufficient capacity!");
					pouredWater -= litters;
				}
			}
			Console.WriteLine(pouredWater);
		}
	}
}
