using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> inputOne = Console.ReadLine()
			.Split(" ", StringSplitOptions.RemoveEmptyEntries)
			.Select(int.Parse)
			.ToList();

			List<int> inputTwo = Console.ReadLine()
			.Split(" ", StringSplitOptions.RemoveEmptyEntries)
			.Select(int.Parse)
			.ToList();

			List<int> output = new List<int>();
			int num = Math.Max(inputOne.Count, inputTwo.Count);

			for (int i = 0; i < num; i++)
			{
				if (i < inputOne.Count)
				{
					output.Add(inputOne[i]);
				}

				if (i < inputTwo.Count)
				{
					output.Add(inputTwo[i]);
				}
			}

			Console.WriteLine(string.Join(" ", output));
		}
	}
}
