using System;

namespace _05.AppliedArithmetics
{
	class Program
	{
		static void Main(string[] args)
		{

			Func<int[], int[]> sum = numbers =>
			{
				for (int i = 0; i < numbers.Length; i++)
				{
					numbers[i] += 1;
				}
				return numbers;
			};

			Func<int[], int[]> subtract = numbers =>
			{
				for (int i = 0; i < numbers.Length; i++)
				{
					numbers[i] -= 1;
				}
				return numbers;
			};

			Func<int[], int[]> multiply = numbers =>
			{
				for (int i = 0; i < numbers.Length; i++)
				{
					numbers[i] *= 1;
				}
				return numbers;
			};

			Action<int[]> printNumbers = numbers
				=> Console.WriteLine(string.Join(" ", numbers));

			int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
			string command = Console.ReadLine();

			while (command != "end")
			{
				if (command == "add")
				{
					sum(input);
				}
				else if (command == "subtract")
				{
					subtract(input);
				}
				else if (command == "multiply")
				{
					multiply(input);
				}
				else if (command == "print")
				{
					printNumbers(input);
				}
				command = Console.ReadLine();
			}
		}
	}
}
