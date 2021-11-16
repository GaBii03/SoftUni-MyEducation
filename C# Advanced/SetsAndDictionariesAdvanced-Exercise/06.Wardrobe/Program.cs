using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			var wardrobe = new Dictionary<string, List<string>>();

			for (int i = 0; i < n; i++)
			{
				string[] input = Console.ReadLine().Split(" -> ");
				string color = input[0];
				string[] clothes = input[1].Split(",");

				if (!wardrobe.ContainsKey(color))
				{
					wardrobe[color] = new List<string>();
				}

				for (int j = 0; j < clothes.Length; j++)
				{
					wardrobe[color].Add(clothes[j]);
				}

			}

			string[] searchedCloth = Console.ReadLine().Split();

			foreach (var item in wardrobe)
			{
				Console.WriteLine($"{item.Key} cloths:");
				for (int i = 0; i < item.Value.Count; i++)
				{
					Console.WriteLine($"* {item.Value[i]}");
				}
			}
		}
	}
}
