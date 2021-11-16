using System;
using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
	class Program
	{
		static void Main(string[] args)
		{
			string input =Console.ReadLine();
			string pattern = @"^%([A-Z]{1}[a-z]{1,})%.*<(\w+)>.*\|([0-9]+)\|.*?([0-9.]+)\$$";
			decimal income = 0;
			while (input!= "end of shift")
			{
				Match match = Regex.Match(input, pattern);
				if (!match.Success)
				{
					input = Console.ReadLine();
					continue;
				}
				string customerName = match.Groups[1].Value;
				string product = match.Groups[2].Value;
				int count = int.Parse(match.Groups[3].Value);
				decimal price = decimal.Parse(match.Groups[4].Value);
				decimal totalPrice = count*price;
				income += totalPrice;

				Console.WriteLine($"{ customerName}: { product} - { totalPrice:f2}");
				input = Console.ReadLine();
			}
			Console.WriteLine($"Total income: {income:f2}");
		}
	}
}
