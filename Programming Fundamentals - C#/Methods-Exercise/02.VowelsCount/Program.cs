using System;

namespace _02.VowelsCount
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine().ToLower();
			CheckVowels(input);
		}

		static void CheckVowels(string input)
		{
			string text = input;
			char current = ' ';
			int sumVowels = 0;
			for (int i = 0; i < text.Length; i++)
			{
				current = text[i];
				switch (current)
				{
					case 'a':
					case 'o':
					case 'u':
					case 'e':
					case 'i':
						sumVowels++;
						break;
				}
			}

			Console.WriteLine(sumVowels);
		}
	}
}
