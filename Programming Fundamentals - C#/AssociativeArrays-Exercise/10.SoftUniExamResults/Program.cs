using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniExamResults
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			var information = new Dictionary<string, List<string>>();

			while (input != "Lumpawaroo")
			{
				string[] inputArr = input.Split();
				string command = inputArr[1];

				if (command == "|")
				{
					string forceSide = inputArr[0];
					string forceUser = inputArr[2];

					if (!information.ContainsKey(forceSide))
					{
						information.Add(forceSide, new List<string>());
						information[forceSide].Add(forceUser);
					}
					else if (information.ContainsKey(forceSide) && information[forceSide].Contains(forceUser))
					{
						information[forceSide].Add(forceUser);
					}
				}
				else if (command == "->")
				{
					string forceUser = inputArr[0];
					string forceSide = inputArr[2];

					if (!information.ContainsKey(forceSide))
					{
						information.Add(forceSide, new List<string>());
						information[forceSide].Add(forceUser);
					}
					else
					{
						information[forceSide].Add(forceUser);
					}
				}

				input = Console.ReadLine();
			}

			foreach (var item in information.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Value))
			{
				Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
				for (int i = 0; i < item.Value.Count; i++)
				{
					Console.WriteLine($"! {item.Value[i]}");
				}
			}

		}
	}
}
