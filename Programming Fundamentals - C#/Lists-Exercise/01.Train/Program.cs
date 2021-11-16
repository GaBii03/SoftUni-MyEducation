using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> wagons = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToList();

			int maxCapacity = int.Parse(Console.ReadLine());
			string command = Console.ReadLine();

			while (command != "end")
			{
				string[] commandArr = command.Split();
				string action = commandArr[0];
				if (action == "Add")
				{
					int number = int.Parse(commandArr[1]);
					wagons.Add(number);
				}
				else
				{
					int number = int.Parse(commandArr[0]);
					for (int i = 0; i < wagons.Count; i++)
					{
						if (wagons[i] + number <= maxCapacity)
						{
							wagons[i] += number;
							break;
						}
					}
				}
				command = Console.ReadLine();
			}

			Console.WriteLine(string.Join(" ", wagons));
		}
	}
}
