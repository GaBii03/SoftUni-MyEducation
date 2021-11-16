using System;

namespace _10.TopNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			int input = int.Parse(Console.ReadLine());
			for (int i = 17; i <= input; i++)
			{
				if (IsDivisibleBy8(i) && IsContainsOddNumber(i))
				{
					Console.WriteLine(i);
				}
			}
		}

		static bool IsContainsOddNumber(int i)
		{
			while (i>0)
			{
				int currentDigit = i % 10;
				if (currentDigit%2==1)
				{
					bool containsOdds = true;
					return containsOdds;
				}
				i /= 10;
			}
			return false;
		}

		static bool IsDivisibleBy8(int i)
		{
			int sum = 0;
			while (i>0)
			{
				sum += i % 10;
				i /= 10;
			}

			bool isDivisible = (sum % 8 == 0);
			return isDivisible;
		}
	}
}
