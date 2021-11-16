using System;

namespace _08.TriangleOfNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int columnsN = 1;
			for (int rows = 1; rows <= n; rows++)
			{
				for (int columns = 1; columns <= columnsN; columns++)
				{
					Console.Write(columnsN + " ");
				}
				columnsN++;
				Console.WriteLine();
			}
			
		}
	}
}
