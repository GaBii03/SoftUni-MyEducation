using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, int> things = new Dictionary<string, int>();
			string input = Console.ReadLine();
			while (input!= "stop" )
			{
				string name = input;
				int quantity = int.Parse(Console.ReadLine());
				if (!things.ContainsKey(name))
				{
					things.Add(name, quantity);
				}
				else
				{
					things[name] += quantity;
				}

				input = Console.ReadLine();
			}

			foreach (var item in things)
			{
				Console.WriteLine($"{item.Key} -> {item.Value}");
			}
		}
	}
}
