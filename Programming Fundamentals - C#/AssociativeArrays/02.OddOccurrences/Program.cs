using System;
using System.Collections.Generic;

namespace _02.OddOccurrences
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split();
			Dictionary<string, int> counts = new Dictionary<string, int>();

			foreach (var word in input)
			{
				string wordLowerCase = word.ToLower();
				if (counts.ContainsKey(wordLowerCase))
				{
					counts[wordLowerCase]++;
				}
				else
				{
					counts.Add(wordLowerCase, 1);
				}
			}

			foreach (var count in counts)
			{
				if (count.Value%2!=0)
				{
					Console.Write(count.Key + " ");
				}
			}
		}
	}
}
