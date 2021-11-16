using System;
using System.Linq;

namespace _01.SumMatrixElements
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] firstLine = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
			int rows = firstLine[0];
			int cols = firstLine[1];
			int[,] numbers = new int[rows, cols];

			for (int row = 0; row < rows; row++)
			{
				string[] lineParts = Console.ReadLine().Split(", ");
				for (int col = 0; col < cols; col++)
				{
					numbers[row, col] = int.Parse(lineParts[col]);
				}
			}

			int sum = 0;
			for (int row = 0; row < numbers.GetLength(0); row++)
			{
				for (int col = 0; col < numbers.GetLength(1); col++)
				{
					sum += numbers[row, col];
				}
			}

			Console.WriteLine(numbers.GetLength(0));
			Console.WriteLine(numbers.GetLength(1));
			Console.WriteLine(sum);
		}
	}
}
