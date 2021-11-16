using System;

namespace _03.Elevator
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberPeople = int.Parse(Console.ReadLine());
			int capacity = int.Parse(Console.ReadLine());
			int counterCourses = 0;

			while (numberPeople>0)
			{
				numberPeople -= capacity;
				counterCourses++;
			}

			Console.WriteLine(counterCourses);
		}
	}
}
