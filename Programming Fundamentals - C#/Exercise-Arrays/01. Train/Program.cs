using System;

namespace _01._Train
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] train = new int[n];
			int totalPeople = 0;
			int peopleInWagon = 0;
			for (int i = 0; i < n; i++)
			{
				peopleInWagon = int.Parse(Console.ReadLine());
				train[i] = peopleInWagon;
				totalPeople += peopleInWagon;
			}
			Console.WriteLine(string.Join(" ", train));
			Console.WriteLine(totalPeople);
		}
	}
}
