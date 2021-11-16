using System;

namespace _04.FindEvensOrOdds
{
	class Program
	{
		static void Main(string[] args)
		{
			Predicate<int> isEven = number => number % 2 == 0;
			Action<int[]> printIntagers = inputNumber
				=> Console.WriteLine(string.Join(" ", inputNumber));
			List<int> numbers = new List<int>();
			int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();
			for (int i = range[0]; i <= range[1]; i++)
			{
				numbers.Add(i);
			}
			string command = Console.ReadLine();

			if (command == "even")
			{
				printIntagers(numbers.Where(x => isEven(x)).ToArray());
			}
			else if (command == "odd")
			{
				printIntagers(numbers.Where(x => !isEven(x)).ToArray());
			}
		}
	}
}
