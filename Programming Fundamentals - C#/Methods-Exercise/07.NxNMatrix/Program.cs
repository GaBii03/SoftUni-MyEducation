using System;

namespace _07.NxNMatrix
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			for (int i = 1; i <= n; i++)
			{
				PrintResult(n);
			}
			
		}

		static void PrintResult(int n)
		{
			int[] array = new int[n];
			for (int i = 0; i < n; i++)
			{
				array[i] = n;
			}

			for (int i = 0; i < n; i++)
			{
				Console.Write(array[i] + " ");
			}
			Console.WriteLine();
		}
	}
}
