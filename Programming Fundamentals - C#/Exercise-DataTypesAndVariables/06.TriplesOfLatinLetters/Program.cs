using System;

namespace _06.TriplesOfLatinLetters
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			for (char i = (char)97; i <= n + 96; i++)
			{
				for (char j = (char)97; j <= n + 96; j++)
				{
					for (char k = (char)97; k <= n + 96; k++)
					{
						Console.WriteLine($"{i}{j}{k}");
					}
				}
			}
		}
	}
}
