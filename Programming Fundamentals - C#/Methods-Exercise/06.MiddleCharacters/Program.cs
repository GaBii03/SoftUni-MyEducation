using System;

namespace _06.MiddleCharacters
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			if (input.Length % 2 ==0 )
			{
				string middleChars = CheckMiddleEven(input);
				Console.WriteLine(middleChars);
			}
			else 
			{
				char middleChar = CheckMiddleOdd(input);
				Console.WriteLine(middleChar);
			}
		}

		static char CheckMiddleOdd(string input)
		{
			int middleCharIndex = (input.Length / 2);
			char middleChar= input[middleCharIndex];
			return middleChar;
		}

		static string CheckMiddleEven(string input)
		{
			int middleFirstCharIndex = (input.Length / 2) -1;
			int middleSecCharIndex = (input.Length / 2) ;
			string text = $"{input[middleFirstCharIndex]}{input[middleSecCharIndex]}";
			return text;
		}
	}
}
