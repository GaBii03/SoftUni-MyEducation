using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ListManipulationAdvanced
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> input = Console.ReadLine()
			.Split(" ", StringSplitOptions.RemoveEmptyEntries)
			.Select(int.Parse)
			.ToList();
			List<int> original = input.ToList();
			bool changesMade = false;
			string command = Console.ReadLine();
			while (command != "end")
			{
				string[] commandArr = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
				string action = commandArr[0];

				if (action == "Contains")
				{
					int number = int.Parse(commandArr[1]);
					bool contains = input.Contains(number);
					if (contains)
					{
						Console.WriteLine("Yes");
					}
					else
					{
						Console.WriteLine("No such number");
					}
				}
				else if (action == "PrintEven")
				{
					List<int> even = new List<int>();
					for (int i = 0; i < input.Count; i++)
					{
						if (input[i] % 2 == 0)
						{
							even.Add(input[i]);
						}
					}
					Console.WriteLine(string.Join(" ", even));
				}
				else if (action == "PrintOdd")
				{
					List<int> odd = new List<int>();
					for (int i = 0; i < input.Count; i++)
					{
						if (input[i] % 2 == 1)
						{
							odd.Add(input[i]);
						}
					}
					Console.WriteLine(string.Join(" ", odd));
				}
				else if (action == "GetSum")
				{
					int sum = 0;
					for (int i = 0; i < input.Count; i++)
					{
						sum += input[i];
					}
					Console.WriteLine(sum);
				}
				else if (action == "Filter")
				{
					string condition = commandArr[1];
					int number = int.Parse(commandArr[2]);
					List<int> filter = new List<int>();
					if (condition == "<")
					{
						for (int i = 0; i < input.Count; i++)
						{
							if (input[i] < number)
							{
								filter.Add(input[i]);
							}
						}
					}
					else if (condition == ">")
					{
						for (int i = 0; i < input.Count; i++)
						{
							if (input[i] > number)
							{
								filter.Add(input[i]);
							}
						}
					}
					else if (condition == "<=")
					{
						for (int i = 0; i < input.Count; i++)
						{
							if (input[i] <= number)
							{
								filter.Add(input[i]);
							}
						}
					}
					else if (condition == ">=")
					{
						for (int i = 0; i < input.Count; i++)
						{
							if (input[i] >= number)
							{
								filter.Add(input[i]);
							}
						}
					}
					Console.WriteLine(string.Join(" ", filter));
				}
				else if (action == "Add")
				{
					int number = int.Parse(commandArr[1]);
					input.Add(number);
					changesMade = true;
				}
				else if (action == "Remove")
				{
					int number = int.Parse(commandArr[1]);
					input.Remove(number);
					changesMade = true;
				}
				else if (action == "RemoveAt")
				{
					int number = int.Parse(commandArr[1]);
					input.RemoveAt(number);
					changesMade = true;
				}
				else if (action == "Insert")
				{
					int number = int.Parse(commandArr[1]);
					int index = int.Parse(commandArr[2]);
					input.Insert(index, number);
					changesMade = true;
				}

				command = Console.ReadLine();
			}
			if (input!= original && changesMade )
			{
				Console.WriteLine(string.Join(" ", input));
			}
		}
	}
}
