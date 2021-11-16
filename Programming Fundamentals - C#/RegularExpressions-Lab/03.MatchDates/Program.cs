using System;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
	class Program
	{
		static void Main(string[] args)
		{

			var input = Console.ReadLine();
			var regex = @"((?<day>[0-9]{2})(.*)(?<month>[A-Z][a-z]{2})\2(?<year>[0-9]{4}))";

			var validDstes = Regex.Matches(input, regex);

			foreach (Match date in validDstes)
			{
				var day = date.Groups["day"].Value;
				var month = date.Groups["month"].Value;
				var year = date.Groups["year"].Value;

				Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
			}


		}
	}
}
