﻿using System;

namespace _08.TownInfo
{
	class Program
	{
		static void Main(string[] args)
		{
			string townName = Console.ReadLine();
			int population = int.Parse(Console.ReadLine());
			float area = float.Parse(Console.ReadLine());

			Console.WriteLine($"Town {townName} has population of {population} and area {area} square km.");
		}
	}
}
