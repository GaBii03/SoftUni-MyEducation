using System;
using System.Linq;

namespace _03.Zig_ZagArrays
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] firstArray = new int[n];
			int[] secArray = new int[n];
			
			for (int i = 0; i < n; i++)
			{
				int[] givenNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
				int firstNum = givenNumbers[0];
				int secNum = givenNumbers[1];

				if (i % 2 == 0)
				{
					firstArray[i] = firstNum;
					secArray[i] = secNum;
				}
				else
				{
					firstArray[i] = secNum;
					secArray[i] = firstNum;
				}
			}

			Console.WriteLine(string.Join(" ", firstArray));
			Console.WriteLine(string.Join(" ", secArray));
		}
	}
}
