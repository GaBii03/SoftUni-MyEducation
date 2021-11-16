using System;

namespace _02.SumMatrixColumns
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] firstLine = Console.ReadLine().Split(", ");
			int rows = int.Parse(firstLine[0]);
			int cols = int.Parse(firstLine[1]);
			int[,] table = new int[rows, cols];
			int[] sums = new int[cols];
			for (int row = 0; row < rows; row++)
			{
				string[] followingLine = Console.ReadLine().Split();
				for (int col = 0; col < cols; col++)
				{
					table[row, col] = int.Parse(followingLine[col]);
					sums[col] += int.Parse(followingLine[col]);
				}
			}

			for (int i = 0; i < cols; i++)
			{
				Console.WriteLine(sums[i]);
			}
		}
	}
}
