using System;

namespace _10.PokeMon
{
	class Program
	{
		static void Main(string[] args)
		{
			int pokePower = int.Parse(Console.ReadLine());
			int distance = int.Parse(Console.ReadLine());
			int exhaustionFactor = int.Parse(Console.ReadLine());
			int counter = 0;
			int availablePokePower = pokePower;

			while (availablePokePower >= distance)
			{
				availablePokePower -= distance;
				counter++;
				if (availablePokePower == pokePower / 2 && exhaustionFactor>0)
				{
					availablePokePower /= exhaustionFactor;
				}
			}

			Console.WriteLine(availablePokePower);
			Console.WriteLine(counter);
			
		}
	}
}
