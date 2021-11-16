using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativesAndReverse
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> input = Console.ReadLine()
			.Split(" ", StringSplitOptions.RemoveEmptyEntries)
			.Select(int.Parse)
			.ToList();

			for (int i = input.Count - 1; i >= 0; i--)
			{
				if (input[i]<0)
				{
					input.RemoveAt(i);
				}
			}

			if (input.Count==0)
			{
				Console.WriteLine("empty");
			}
			else
			{
				input.Reverse();
				Console.WriteLine(string.Join(" ", input));
			}
			
			
		}
	}
}
