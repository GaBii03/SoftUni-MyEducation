using System;

namespace _10.MultiplyEvensByOdds
{
	class Program
	{
		static void Main(string[] args)
		{
			int input = int.Parse(Console.ReadLine());
			input = Math.Abs(input);

			int sumEven = GetSumOfEvenDigits(input);
			int sumOdd = GetSumOfOddDigits(input);

			int result = GetMultipleOfEvenAndOdds(sumEven, sumOdd);

			Console.WriteLine(result);
		}

		private static int GetMultipleOfEvenAndOdds(int a, int b)
		{
			int result = a * b;
			return result;
		}

		private static int GetSumOfOddDigits(int a)
		{
			string inputArray = a.ToString();
			int sumOdd = 0;
			foreach (var item in inputArray)
			{
				if (item%2==1)
				{
					sumOdd+= (int)char.GetNumericValue(item);
				}
				
			}
			return sumOdd;
		}

		private static int GetSumOfEvenDigits(int a)
		{
			string inputArray = a.ToString();
			int sumEven = 0;
			foreach (var item in inputArray)
			{
				if (item % 2 == 0)
				{
					sumEven += (int)char.GetNumericValue(item);
				}

			}
			return sumEven;
		}
	}
}
