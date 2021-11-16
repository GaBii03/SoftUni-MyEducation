using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.BombNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> input = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToList();

			int[] additions = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

			int number = additions[0];
			int range = additions[1];

			for (int i = 0; i < input.Count; i++)
			{
				if (input[i] == number)
				{
					int start = i - range;
					int final = i + range;

					if (start<0)
					{
						start = 0;
					}

					if (final>input.Count-1)
					{
						final = input.Count - 1;
					}

					for (int j = start; j <= final ; j++)
					{
						input[j] = 0;
					}
				}
			}
			Console.WriteLine(input.Sum());
			
		}
	}
}
