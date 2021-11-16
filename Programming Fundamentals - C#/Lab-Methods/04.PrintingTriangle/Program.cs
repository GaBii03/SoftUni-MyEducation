using System;

namespace _04.PrintingTriangle
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			PrintingTriangle(n);
		}

		static void PrintingTriangle(int n)
		{
			for (int row = 1; row <= n; row++)
			{
				PrintCollon(row);
				Console.WriteLine();
			}

			for (int row = n - 1; row >= 1; row--)
			{
				PrintCollon(row);
				Console.WriteLine();
			}
			
		}

		static void PrintCollon(int row)
		{
			for (int i = 1; i <= row; i++)
			{
				Console.Write(i + " ");
			}
		}
	}
}
