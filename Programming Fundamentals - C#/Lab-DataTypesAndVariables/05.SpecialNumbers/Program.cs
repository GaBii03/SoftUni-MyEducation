using System;

namespace _05.SpecialNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			
			for (int i = 1; i <= n; i++)
			{
				int num = i;
				int sumDigits = 0;
				while (num != 0)
				{
					int currentDigit = num % 10;
					sumDigits += currentDigit;
					num = num / 10;
				}

				bool isSpecial = false;

				if (sumDigits == 5 || sumDigits == 7 || sumDigits == 11)
				{
					isSpecial = true;
				}

				Console.WriteLine($"{i} -> {isSpecial}");
			}
		}
	}
}
