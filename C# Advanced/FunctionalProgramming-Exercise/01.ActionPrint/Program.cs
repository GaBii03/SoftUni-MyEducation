using System;

namespace _01.ActionPrint
{
	class Program
	{
		static void Main(string[] args)
		{

			string[] input = Console.ReadLine().Split();
			Action<string[]> printCollection = input => Console.WriteLine(string.Join(Environment.NewLine, input));

			printCollection(input);
		}
	}
}
