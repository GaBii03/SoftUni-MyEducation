using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
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
			while (command != "End")
			{
				string[] commandsArr = command.Split();
				string action = commandsArr[0];
				if (action == "Add")
				{
					int number = int.Parse(commandsArr[1]);
					input.Add(number);
				}
				else if (action == "Insert")
				{
					int number = int.Parse(commandsArr[1]);
					int index = int.Parse(commandsArr[2]);
					bool isCorrect = IsCorrect(index, input);
					if (!isCorrect)
					{
						Console.WriteLine("Invalid index");
						command = Console.ReadLine();
						continue;
					}
					input.Insert(index, number);
				}
				else if (action == "Remove")
				{
					int index = int.Parse(commandsArr[1]);
					bool isCorrect = IsCorrect(index, input);
					if (!isCorrect)
					{
						Console.WriteLine("Invalid index");
						command = Console.ReadLine();
						continue;
					}
					input.RemoveAt(index);
				}
				else if (action == "Shift")
				{
					if (commandsArr[1] == "left")
					{
						int count = int.Parse(commandsArr[2]);
						for (int i = 0; i < count; i++)
						{
							int firstElement = input[0];
							input.RemoveAt(0);
							input.Add(firstElement);
						}
					}
					else if (commandsArr[1] == "right")
					{
						int count = int.Parse(commandsArr[2]);

						for (int i = 0; i < count; i++)
						{
							int lastElement = input[input.Count - 1];
							input.RemoveAt(input.Count - 1);
							input.Insert(0, lastElement);
						}
					}
				}

				command = Console.ReadLine();
			}

			Console.WriteLine(string.Join(" ", input));
		}

		static bool IsCorrect(int index, List<int> input)
		{
			bool respond = false;
			if (index < input.Count && index >= 0)
			{
				respond = true;
			}
			return respond;
		}
	}
}
