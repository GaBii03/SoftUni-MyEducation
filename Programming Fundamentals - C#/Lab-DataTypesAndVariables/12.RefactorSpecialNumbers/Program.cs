using System;

namespace _12.RefactorSpecialNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			
			for (int i= 1; i <= number; i++)
			{
				int num = i;
				int sum = 0;
				while (num > 0)
				{
					sum += num % 10;
					num /= 10;
				}
				
				bool isSpecial= false;
				isSpecial = (sum == 5) || (sum == 7) || (sum == 11);

				Console.WriteLine($"{i} -> {isSpecial}");

			}

		}
	}
}
