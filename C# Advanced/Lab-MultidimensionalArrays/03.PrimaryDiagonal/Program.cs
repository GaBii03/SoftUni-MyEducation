using System;

namespace _03.PrimaryDiagonal
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[,] table = new int[n, n];
			int sum = 0;
			for (int row = 0; row < n; row++)
			{
				string[] line = Console.ReadLine().Split();
				for (int col = 0; col < n; col++)
				{
					table[row, col] = int.Parse(line[col]);
					if (row==col)
					{
						sum += int.Parse(line[col]);
					}
				}
			}

			Console.WriteLine(sum);
		}
	}
}
