using System;

namespace _08.BeerKegs
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			double biggestModel = double.MinValue;
			string biggestModelName = "";

			for (int i = 1; i <= n; i++)
			{
				double volume = 0;
				string model = Console.ReadLine();
				double radius = double.Parse(Console.ReadLine());
				int height = int.Parse(Console.ReadLine());
				volume = Math.PI * radius * radius * height;

				if (volume > biggestModel)
				{
					biggestModel = volume;
					biggestModelName = model;
				}
			}
			Console.WriteLine(biggestModelName);
		}
	}
}
