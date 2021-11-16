using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.AnonymousThreat
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> input = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.ToList();

			string command = Console.ReadLine();
			while (command != "3:1")
			{
				string[] commandArr = command.Split();
				string action = commandArr[0];

				if (action == "merge")
				{
					int startIndex = int.Parse(commandArr[1]);
					int endIndex = int.Parse(commandArr[2]);
					if (startIndex > input.Count)
					{
						command = Console.ReadLine();
						continue;
					}
					if (startIndex < 0)
					{
						startIndex = 0;
					}
					if (endIndex > input.Count)
					{
						endIndex = input.Count - 1;
					}

					string mergedText = string.Empty;
					int range = endIndex - startIndex + 1;
					for (int i = startIndex; i <= endIndex; i++)
					{
						mergedText += input[i];
					}
					input.Insert(startIndex, mergedText);
					input.RemoveRange(startIndex + 1, range);

				}
				else if (action == "divide")
				{
					int index = int.Parse(commandArr[1]);
					int partitions = int.Parse(commandArr[2]);
					string indexWorking = input[index];
					input.RemoveAt(index);
					int eachPartWith = indexWorking.Length / partitions;
					int counter = 0;
					int startindLoopIndex = 0;
					int finishLoopIndex = eachPartWith;

					while (counter != partitions)
					{
						string currDivided = string.Empty;

						for (int i = startindLoopIndex; i < finishLoopIndex; i++)
						{
							currDivided += indexWorking[i];
						}

						if (indexWorking.Length % partitions == 1 && counter == partitions - 1)
						{
							for (int i = eachPartWith; i < indexWorking.Length; i++)
							{
								currDivided += indexWorking[i];
							}

						}

						input.Insert(index, currDivided);
						index++;
						startindLoopIndex += eachPartWith;
						finishLoopIndex += eachPartWith;
						counter++;
					}
				}

				command = Console.ReadLine();
			}

			Console.WriteLine(string.Join(" ", input));
		}
	}
}
