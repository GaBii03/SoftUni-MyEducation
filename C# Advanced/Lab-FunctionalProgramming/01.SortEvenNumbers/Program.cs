using System;
using System.Linq;

namespace _01.SortEvenNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			var numbers = Console.ReadLine()
				.Split(", ")
				.Select(int.Parse)
				.Where(number => number % 2 == 0)
				.OrderBy(number => number);
			Console.WriteLine(string.Join(", ", numbers));
		}
	}
}
