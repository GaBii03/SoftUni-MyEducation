using System;

namespace _08.MathPower
{
	class Program
	{
		static void Main(string[] args)
		{
			double number = double.Parse(Console.ReadLine());
			int power = int.Parse(Console.ReadLine());

			double result = CalculateResult(number, power);
			
			Console.WriteLine(result);
		}

		static double CalculateResult(double n, int p)
		{
			double poweredNumber = n;

			for (int i = 1; i < p; i++)
			{
				poweredNumber *= n;
			}

			return poweredNumber;
		}
	}
}
