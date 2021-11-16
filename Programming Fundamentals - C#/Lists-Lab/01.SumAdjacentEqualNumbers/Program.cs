using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SumAdjacentEqualNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<double> input = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(double.Parse)
				.ToList();

			for (int i = 0; i <= input.Count; i++)
			{
				if (i+1>=input.Count)
				{
					break;
				}

				if (input[i] == input[i+1])
				{
					input[i] = input[i] + input[i + 1];
					input.Remove(input[i + 1]);
					i = -1;
				}
			}
			Console.WriteLine(string.Join(" ",input));
		}
	}
}
