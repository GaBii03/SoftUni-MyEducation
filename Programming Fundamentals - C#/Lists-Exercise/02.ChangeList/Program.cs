using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> input = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToList();

			string command = Console.ReadLine();

			while (command != "end")
			{
				string[] commandArr = command.Split();
				string action = commandArr[0];
				int element = int.Parse(commandArr[1]);
				if (action == "Delete")
				{
					input.RemoveAll(x => x == element);
				}
				else if (action == "Insert")
				{
					int position = int.Parse(commandArr[2]);
					input.Insert(position, element);
				}
				command = Console.ReadLine();
			}
			Console.WriteLine(string.Join(" ", input));
		}
	}
}
