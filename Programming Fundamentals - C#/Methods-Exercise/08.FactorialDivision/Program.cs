using System;

namespace _08.FactorialDivision
{
	class Program
	{
		static void Main(string[] args)
		{
			int n1 = int.Parse(Console.ReadLine());
			int n2 = int.Parse(Console.ReadLine());

			double factorialN1 = Factorial(n1);
			double factorialN2 = Factorial(n2);
			string result = FactorialDivision(factorialN1, factorialN2);
			Console.WriteLine(result);
		}

		private static string FactorialDivision(double factorialN1, double factorialN2)
		{
			string result = $"{(factorialN1 / factorialN2):f2}" ;
			return result;
		}

		private static double Factorial(int n)
		{
			double result = 1;
			for (int i = n; i > 0; i--)
			{
				result *= i;
			}
			return result;
		}
	}
}
