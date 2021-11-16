using System;

namespace _05.PrintPartOfASCIITable
{
	class Program
	{
		static void Main(string[] args)
		{
			int start = int.Parse(Console.ReadLine());
			int stop = int.Parse(Console.ReadLine());

			for (char i = (char)start; i <= stop; i++)
			{
				Console.Write($"{i} ");
			}
		}
	}
}
