using System;

namespace _07.RepeatString
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			int n = int.Parse(Console.ReadLine());
			string output = Text(input, n);
			Console.WriteLine(output);
		}

		static string Text(string input, int n)
		{
			string output = null;
			for (int i = 0; i < n; i++)
			{
				output += input;
			}
			return output;
		}
	}
}
