using System;
using System.Collections.Generic;

namespace _05.CountSymbols
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			SortedDictionary<char, int> dic = new SortedDictionary<char, int>();
			for (int i = 0; i < input.Length; i++)
			{
				char currChar = input[i];
				if (!dic.ContainsKey(currChar))
				{
					dic.Add(currChar, new int());
				}

				dic[currChar] += 1;

			}

			foreach (var item in dic)
			{
				Console.WriteLine($"{item.Key}: {item.Value} time/s");
			}
		}
	}
}
