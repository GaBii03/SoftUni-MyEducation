using System;

namespace _02.Division
{
	class Program
	{
		static void Main(string[] args)
		{
			double number = double.Parse(Console.ReadLine());
			int num = 0;
			if (number%10==0)
			{
				num = 10;
			}
			else if (number%7==0)
			{
				num = 7;
			}
			else if (number%6==0)
			{
				num = 6;
			}
			else if (number%3==0)
			{
				num = 3;
			}
			else if (number%2==0)
			{
				num = 2;
			}

			if (num>0)
			{
				Console.WriteLine($"The number is divisible by {num}");
			}
			else
			{
				Console.WriteLine("Not divisible");
			}
		}
	}
}
