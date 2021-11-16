using System;

namespace _05.AddAndSubtract
{
	class Program
	{
		static void Main(string[] args)
		{
			int n1 = int.Parse(Console.ReadLine());
			int n2 = int.Parse(Console.ReadLine());
			int n3 = int.Parse(Console.ReadLine());
			int sumN1N2 = Sum(n1, n2);
			int finalSum = Subtract(sumN1N2, n3);
			Console.WriteLine(finalSum);
		}

		private static int Subtract(int sumN1N2, int n3)
		{
			int result = sumN1N2 - n3;
			return result;
		}

		static int Sum(int n1, int n2)
		{
			int result = n1 + n2;
			return result;
		}
	}
}
