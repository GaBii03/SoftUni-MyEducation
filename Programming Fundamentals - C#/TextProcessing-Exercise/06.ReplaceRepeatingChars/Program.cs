using System;
using System.Text;

namespace _06.ReplaceRepeatingChars
{
	class Program
	{
		static void Main(string[] args)
		{

			string input = Console.ReadLine();
			StringBuilder output = new StringBuilder();
			char currchar = ' ';
			for (int i = 0; i < input.Length; i++)
			{
				if (i == input.Length - 1)
				{
					if (input[i] != currchar)
					{
						output = output.Append(input[i]);
					}
				}
				else if (input[i] != currchar)
				{
					output = output.Append(input[i]);
					currchar = input[i];
				}
			}

			Console.WriteLine(output);
		}
	}
}
