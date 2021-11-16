using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> input = Console.ReadLine()
				.Split("|", StringSplitOptions.RemoveEmptyEntries)
				.ToList();

			List<int> result = new List<int>();

			for (int i = input.Count - 1; i >= 0; i--)
			{
				int[] numbers = input[i]
					.Split(" ", StringSplitOptions.RemoveEmptyEntries)
					.Select(int.Parse)
					.ToArray();

				foreach (var VARIABLE in numbers)
				{
					result.Add(VARIABLE);
				}
				
			}
			Console.WriteLine(string.Join(" ", result));
		}
	}
}
