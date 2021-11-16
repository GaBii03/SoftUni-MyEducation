using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.StarEnigma
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());

			List<string> destroyedPlanets = new List<string>();
			List<string> attackedPlanets = new List<string>();
			for (int j = 1; j <= number; j++)
			{
				string input = Console.ReadLine();
				int counter = 0;
				for (int i = 0; i < input.Length; i++)
				{
					if (input[i] == 's' || input[i] == 'S' || input[i] == 't' || input[i] == 'T' || input[i] == 'a' || input[i] == 'A' || input[i] == 'r' || input[i] == 'R')
					{
						counter++;
					}
				}

				string result = string.Empty;
				for (int i = 0; i < input.Length; i++)
				{
					result += ((char)(input[i] - counter));
				}

				string pattern = @"@(?<name>[A-Za-z]+)(.*):(?<population>[0-9]+)(.*)!(?<attackType>[AD])!(.*)->(?<soldierCount>[0-9]+)";
				Match match = Regex.Match(result, pattern);
				if (!match.Success)
				{
					continue;
				}

				string name = match.Groups["name"].Value;
				int population = int.Parse(match.Groups["population"].Value);
				string attackType = match.Groups["attackType"].Value;
				int soldierCount = int.Parse(match.Groups["soldierCount"].Value);

				if (attackType == "A")
				{
					attackedPlanets.Add(name);
				}
				else if (attackType == "D")
				{
					destroyedPlanets.Add(name);
				}

			}

			Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
			
			foreach ( var item in attackedPlanets.OrderBy(X=>X))
			{
				Console.WriteLine($"-> {item}");
			}

			Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
			
			foreach (var item in destroyedPlanets.OrderBy(X => X))
			{
				Console.WriteLine($"-> {item}");
			}
		}
	}
}
