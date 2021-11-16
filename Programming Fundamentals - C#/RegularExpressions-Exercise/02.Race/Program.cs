using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Race
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, int> paricipants = new Dictionary<string, int>();
			string[] racers = Console.ReadLine().Split(", ");
			foreach (var recer in racers)
			{
				paricipants.Add(recer, 0);
			}
			string input = Console.ReadLine();

			string lettersPattern = @"[A-Za-z]";
			string digitsPattern = @"[0-9]";


			while (input != "end of race")
			{
				string name = string.Empty;
				int km = 0;
				MatchCollection letters = Regex.Matches(input, lettersPattern);

				foreach (Match letter in letters)
				{
					name += letter.Value;
				}

				if (paricipants.ContainsKey(name))
				{
					MatchCollection digits = Regex.Matches(input, digitsPattern);

					foreach (Match digit in digits)
					{
						km += int.Parse(digit.Value);
					}
					paricipants[name] += km;
				}


				input = Console.ReadLine();
			}
			//string[] names = paricipants.OrderByDescending(x => x.Value)
			//.Select(x => x.Key).ToArray();
			int counter = 1;
			foreach (var item in paricipants.OrderByDescending(x => x.Value))
			{
				if (counter == 1)
				{
					Console.WriteLine($"1st place: {item.Key}");
				}
				else if (counter == 2)
				{
					Console.WriteLine($"2nd place: {item.Key}");
				}
				else if (counter == 3)
				{
					Console.WriteLine($"3rd place: {item.Key}");
				}

				counter++;
			}


		}
	}
}
