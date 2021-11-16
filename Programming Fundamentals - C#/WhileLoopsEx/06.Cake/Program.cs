using System;

namespace _06.Cake
{
	class Program
	{
		static void Main(string[] args)
		{
			int width = int.Parse(Console.ReadLine());
			int lenght = int.Parse(Console.ReadLine());
			int allCakePieces = width * lenght;
			string input =Console.ReadLine();
			
			while (input!="STOP")
			{
				int numberPieces = int.Parse(input);
				allCakePieces -= numberPieces;
				if (allCakePieces<=0)
				{
					Console.WriteLine($"No more cake left! You need {Math.Abs(allCakePieces)} pieces more.");
					break;
				}
				input =Console.ReadLine();
			}

			if (input=="STOP")
			{
				Console.WriteLine($"{allCakePieces} pieces are left.");
			}
		}
	}
}
