using System;

namespace _02.RepeatStrings
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split();
			string output = string.Empty;
			for (int i = 0; i < input.Length; i++)
			{
				for (int j = 0; j < input[i].Length; j++)
				{
					output += input[i];
				}
				
			}

			Console.WriteLine(output);
		}
	}
}
