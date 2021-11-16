using System;
using System.Linq;

namespace _02.SquaresInMatrix
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int rows = input[0];
			int cols = input[1];
			char[,] matrix = new char[rows, cols];
			int counter = 0;
			for (int row = 0; row < rows; row++)
			{
				char[] line = Console.ReadLine().Split().Select(char.Parse).ToArray();
				for (int col = 0; col < cols; col++)
				{
					matrix[row, col] = line[col];
				}
			}

			for (int row = 0; row < rows; row++)
			{
				for (int col = 0; col < cols; col++)
				{
					if (col == 0)
					{
						continue;
					}
					if (row==rows-1)
					{
						break;
					}

					if (matrix[row, col] == matrix[row, col - 1] && matrix[row+1, col] == matrix[row+1, col-1])
					{
						counter++;
						break;
					}
				}
			}

			Console.WriteLine(counter);
		}
	}
}
