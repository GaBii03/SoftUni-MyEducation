using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> first = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToList();

			List<int> second = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToList();

			for (int i = 0; i < first.Count + second.Count; i++)
			{
				if (first.Count==0 || second.Count==0)
				{
					break;
				}
				if (first[i] > second[i])
				{
					first.Add(first[i]);
					first.Add(second[i]);
					second.RemoveAt(i);
					first.RemoveAt(i);
				}
				else if (second[i] > first[i])
				{
					second.Add(second[i]);
					second.Add(first[i]);
					first.RemoveAt(i);
					second.RemoveAt(i);
				}
				else if (first[i]==second[i])
				{
					first.RemoveAt(i);
					second.RemoveAt(i);

				}
				i = -1;
			}
			string winner = string.Empty;
			int sum = 0;
			if (first.Count>second.Count)
			{
				winner = "First";
				sum = first.Sum();
			}
			else
			{
				winner = "Second";
				sum = second.Sum();
			}

			Console.WriteLine($"{winner} player wins! Sum: {sum}");
		}
	}
}
