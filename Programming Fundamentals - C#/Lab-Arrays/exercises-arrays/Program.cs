using System;
using System.Linq;

namespace exercises_arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] line = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

			int[] condensed = new int[line.Length - 1];

			if (line.Length == 1)
			{
				Console.WriteLine(line[0]);
				return;
			}

			for (int n = 0; n < line.Length; n++)
			{
				for (int i = 0; i < condensed.Length-n; i++)
				{
					condensed[i] = line[i] + line[i + 1];
				}
				line = condensed;
			}
			Console.WriteLine(condensed[0]);
		}
	}
}
