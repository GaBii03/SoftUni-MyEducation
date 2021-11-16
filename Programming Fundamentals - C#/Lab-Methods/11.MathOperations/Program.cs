using System;

namespace _11.MathOperations
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			char operatorr = char.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());

			double result = CalculateResult(a, b, operatorr);
			Console.WriteLine(result);

		}

		static double CalculateResult(int a, int b, char operatorr)
		{
			double result = 0;
			if (operatorr == '+')
			{
				result = a + b;
			}
			else if (operatorr == '/')
			{
				result = a / b;
			}
			else if (operatorr== '*')
			{
				result = a * b;
			}
			else if (operatorr== '-')
			{
				result = a - b;
			}
			return result;
		}
	}
}
