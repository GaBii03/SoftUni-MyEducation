using System;

namespace _03.CharactersInRange
{
	class Program
	{
		static void Main(string[] args)
		{
			char first = char.Parse(Console.ReadLine());
			char last = char.Parse(Console.ReadLine());
			PrintBetween(first, last);
		}

		private static void PrintBetween(char a, char b)
		{
			if ((int)a > (int)b)
			{
				int start = (int)b + 1;
				for (char i = (char)start; i < a; i++)
				{
					Console.Write(i + " ");
				}
			}
			else
			{
				int start = (int)a + 1;
				for (char i = (char)start; i < b; i++)
				{
					Console.Write(i + " ");
				}
			}

		}
	}
}
