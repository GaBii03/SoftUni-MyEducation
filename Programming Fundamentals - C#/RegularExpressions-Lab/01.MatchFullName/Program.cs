using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			Regex regex = new Regex (@"\b(?<firstName>[A-Z][a-z]+) (?<secondName>[A-Z][a-z]+)");

			MatchCollection validNames = regex.Matches(input);
			foreach (Match name in validNames)
			{
				Console.Write($"{name.Value} ");
			}
			Console.WriteLine();
		}
	}
}
