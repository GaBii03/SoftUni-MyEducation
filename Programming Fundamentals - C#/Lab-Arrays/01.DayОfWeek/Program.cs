using System;

namespace _01.DayОfWeek
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] dayOfWeek = new string[]
			{
				"Monday",
				"Tuesday",
				"Wednesday",
				"Thursday",
				"Friday",
				"Saturday",
				"Sunday"
			};

			int number = int.Parse(Console.ReadLine());

			if (number<1 || number>7)
			{
				Console.WriteLine("Invalid day!");
			}
			else
			{
				Console.WriteLine(dayOfWeek[number-1]);
			}
		}
	}
}
