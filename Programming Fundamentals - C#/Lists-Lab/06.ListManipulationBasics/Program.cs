using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
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
			while (command!="end")
			{
				string[] commandArr = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
				string action = commandArr[0];
				int number = int.Parse(commandArr[1]);

				if (action== "Add")
				{
					input.Add(number);
				}
				else if (action== "Remove")
				{
					input.Remove(number);
				}
				else if (action=="RemoveAt")
				{
					input.RemoveAt(number);
				}
				else if (action=="Insert")
				{
					int index = int.Parse(commandArr[2]);
					input.Insert(index, number);
				}
				command = Console.ReadLine();
			}

			Console.WriteLine(string.Join(" ",input));
		}
	}
}
