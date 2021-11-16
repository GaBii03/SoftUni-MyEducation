using System;
using System.Linq;

namespace _04.ReverseArrayOfStrings
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] array = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.ToArray();
			for (int i = array.Length - 1; i >= 0; i--)
			{
				Console.Write($"{array[i]} ");
			}
		}
	}
}
