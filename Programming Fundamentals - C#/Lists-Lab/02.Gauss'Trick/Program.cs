using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Gauss_Trick
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> input = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToList();

			for (int i = 0; i < input.Count; i++)
			{
				if (i == input.Count-1)
				{
					break;
				}
				input[i] = input[i] + input[input.Count - 1];
				input.RemoveAt(input.Count - 1);
				
			}
			Console.WriteLine(string.Join(" ", input));
		}
	}
}
