using System;

namespace _02.KnightsofHonor
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> input = Console.ReadLine().Split().ToList();

			Action<List<string>> printCollection = input => input.ForEach(x => Console.WriteLine($"Sir " + x));

			printCollection(input);
		}
	}
}
