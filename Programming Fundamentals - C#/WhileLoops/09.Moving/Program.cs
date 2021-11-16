using System;

namespace _09.Moving
{
	class Program
	{
		static void Main(string[] args)
		{
			int width = int.Parse(Console.ReadLine());
			int lenght = int.Parse(Console.ReadLine());
			int hight = int.Parse(Console.ReadLine());
			int freeSpace = width * lenght * hight;
			int usedSpace = 0;
			string input =Console.ReadLine();
			while (input != "Done")
			{
				int numberBoxes = int.Parse(input);
				usedSpace += numberBoxes;
				if (usedSpace > freeSpace)
				{
					Console.WriteLine($"No more free space! You need {Math.Abs(usedSpace-freeSpace)} Cubic meters more.");
					Environment.Exit(0);
				}

				input = Console.ReadLine();
			}
			Console.WriteLine($"{freeSpace-usedSpace} Cubic meters left.");
		}
	}
}
