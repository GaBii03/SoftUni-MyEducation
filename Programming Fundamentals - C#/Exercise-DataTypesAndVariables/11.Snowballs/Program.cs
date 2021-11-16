using System;
using System.Numerics;

namespace _11.Snowballs
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberSnowballs = int.Parse(Console.ReadLine());
			BigInteger maxValue = 0;
			int bestSnowballSnow = 0;
			int bestSnowballTime = 0;
			int bestSnowballQuality = 0;

			for (int i = 1; i <= numberSnowballs; i++)
			{
				int snowballSnow = int.Parse(Console.ReadLine());
				int snowballTime = int.Parse(Console.ReadLine());
				int snowballQuality = int.Parse(Console.ReadLine());

				BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime ), (snowballQuality));

				if (snowballValue > maxValue)
				{
					maxValue = snowballValue;
					bestSnowballSnow = snowballSnow;
					bestSnowballTime = snowballTime;
					bestSnowballQuality = snowballQuality;
				}
			}

			Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {maxValue} ({bestSnowballQuality})");

		}
	}
}
