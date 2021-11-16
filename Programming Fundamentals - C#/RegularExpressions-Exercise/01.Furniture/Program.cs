using System;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string pattern = @"^>>([A-Za-z]+)<<([0-9.]+)!([0-9]+)";
			Console.WriteLine("Bought furniture: ");
			decimal totalMoney = 0;
			while (input!="Purchase")
			{
				Match match = Regex.Match(input, pattern);
				if (!match.Success)
				{
					input = Console.ReadLine();
					continue;
				}
				string name = match.Groups[1].Value;
				decimal price = decimal.Parse(match.Groups[2].Value);
				int qty = int.Parse(match.Groups[3].Value);

				totalMoney += price * qty;
				Console.WriteLine(name);

				input = Console.ReadLine();
			}
			Console.WriteLine($"Total money spend: {totalMoney:f2}");
		}
	}
}
