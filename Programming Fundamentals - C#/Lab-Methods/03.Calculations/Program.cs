using System;

namespace _03.Calculations
{
	class Program
	{
		static void Main(string[] args)
		{
			string command = Console.ReadLine();
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());

			switch (command)
			{
				case "subtract":
					PrintSubtracted(a, b);
					break;
				case "divide":
					PrintDivided(a, b);
					break;
				case "multiply":
					PrintMultiplied(a, b);
					break;
				case "add":
					PrintAdded(a, b);
					break;

			}
		}

		static void PrintAdded(int a, int b)
		{
			double result = a + b;
			Console.WriteLine(result);
		}

		static void PrintMultiplied(int a, int b)
		{
			double result = a * b;
			Console.WriteLine(result);
		}

		static void PrintDivided(int a, int b)
		{
			double result = a / b;
			Console.WriteLine(result);
		}

		static void PrintSubtracted(int a, int b)
		{
			double result = a - b;
			Console.WriteLine(result);
		}


	}
}
