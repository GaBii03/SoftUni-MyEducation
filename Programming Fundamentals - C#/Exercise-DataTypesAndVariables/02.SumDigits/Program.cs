using System;

namespace _02.SumDigits
{
	class Program
	{
		static void Main(string[] args)
		{
			int integer = int.Parse(Console.ReadLine());

			int num = integer;
			int sum = 0;
			while (num != 0)
			{
				int currentDigit = num % 10;
				sum += currentDigit;
				num /= 10;
			}

			Console.WriteLine(sum);
		}
	}
}
