using System;
using System.Collections.Generic;

namespace _03.PeriodicTable
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			SortedSet<string> elements = new SortedSet<string>();
			for (int i = 0; i < n; i++)
			{
				string[] element = Console.ReadLine().Split();
				for (int j = 0; j < element.Length; j++)
				{
					elements.Add(element[j]);
				}
			}

			Console.WriteLine(string.Join(" ", elements));
		}
	}
}
