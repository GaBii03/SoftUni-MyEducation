using System;
using System.Linq;

namespace _01.DiagonalDifference
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[,] matrix = new int[n, n];
			int sumLR = 0;
			int sumRL = 0;
			for (int row = 0; row < n; row++)
			{
				int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
				for (int col = 0; col < n; col++)
				{
					matrix[row, col] = line[col];
					if (row == col)
					{
						sumLR += line[col];
					}

					if ((row == 0 && col == n - 1) ||(row!=0 && row==n-col-1))
					{
						sumRL+= line[col];
					}
				}
			}

			Console.WriteLine($"{Math.Abs(sumRL-sumLR)}");
		}
	}
}
