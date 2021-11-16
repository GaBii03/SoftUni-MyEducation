using System;

namespace _10.LowerOrUpper
{
	class Program
	{
		static void Main(string[] args)
		{
			char symbol = char.Parse(Console.ReadLine());
			int number = (int)symbol;
			if (number>=65 && number<=90)
			{
				Console.WriteLine("upper-case");
			}
			else if (number >= 97 && number <= 122)
			{
				Console.WriteLine("lower-case");
			}

		}
	}
}
