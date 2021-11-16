using System;
using System.Linq;

namespace _06.Jagged_ArrayModification
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[][] jagged = new int[n][];
			for (int i = 0; i < n; i++)
			{
				int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
				jagged[i] = new int[line.Length];
				for (int j = 0; j < line.Length; j++)
				{
					jagged[i][j] = line[j];
				}
			}

			string command = Console.ReadLine();
			while (command!="END")
			{
				string[] commandArr = command.Split();
				string action = commandArr[0];
				int row = int.Parse(commandArr[1]);
				int col = int.Parse(commandArr[2]);
				int value = int.Parse(commandArr[3]);
				if (row<0 || row>=jagged.Length || col<0 || col>= jagged[row].Length)
				{
					Console.WriteLine("Invalid coordinates");
					command = Console.ReadLine();
					continue;
				}
				else if (action=="Add")
				{
					jagged[row][col] += value;
				}
				else if (action=="Subtract")
				{
					jagged[row][col] -= value;
				}
				command = Console.ReadLine();
			}

			for (int i = 0; i < jagged.Length; i++)
			{
				for (int j = 0; j < jagged[i].Length; j++)
				{
					Console.Write(jagged[i][j] + " ");
				}

				Console.WriteLine();
			}

			//for (int i = 0; i < jagged.Length; i++)
			//{
			//	Console.WriteLine(string.Join(" ", jagged[i]));
			//}
			
		}
	}
}
