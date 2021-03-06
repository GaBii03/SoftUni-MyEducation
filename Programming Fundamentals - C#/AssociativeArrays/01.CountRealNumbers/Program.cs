using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
			SortedDictionary<double, int> count = new SortedDictionary<double, int>();

			foreach (var number in numbers)
			{
				if (count.ContainsKey(number))
				{
					count[number]++;
				}
				else
				{
					count.Add(number, 1);
				}
			}

			foreach (var number in count)
			{
				Console.WriteLine($"{number.Key} -> {number.Value}");
			}
		}
	}
}
