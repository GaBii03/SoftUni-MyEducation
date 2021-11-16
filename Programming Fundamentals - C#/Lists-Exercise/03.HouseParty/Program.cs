using System;
using System.Collections.Generic;

namespace _03.HouseParty
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberCommands = int.Parse(Console.ReadLine());
			List<string> names = new List<string>();
			for (int i = 0; i < numberCommands; i++)
			{
				string command = Console.ReadLine();
				string[] commandsArr = command.Split();
				string name = commandsArr[0];
				if (command==$"{name} is going!")
				{
					if (names.Contains(name)== true)
					{
						Console.WriteLine($"{name} is already in the list!");
					}
					else
					{
						names.Add(name);
					}
				}
				else if (command == $"{name} is not going!")
				{
					if (names.Contains(name) == false)
					{
						Console.WriteLine($"{name} is not in the list!");
					}
					else
					{
						names.Remove(name);
					}
				}
			}

			for (int i = 0; i < names.Count; i++)
			{
				Console.WriteLine(names[i]);
			}
		}
	}
}
