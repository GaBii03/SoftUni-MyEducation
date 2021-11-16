using System;
using System.Linq;

namespace _06.EqualSum
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();//1,2
			bool isFound = false;
			int midle = 0;

			if (array.Length == 1)
			{
				Console.WriteLine(0);
				return;
			}

			for (int i = 0; i < array.Length; i++)
			{
				midle = i;
				int sumLeft = 0;
				int sumRight = 0;
				if (i == 0)
				{
					sumLeft = 0;
					for (int k = i + 1; k < array.Length; k++)
					{
						sumRight += array[k];
					}
				}
				else if (i == array.Length - 1)
				{
					sumRight = 0;
					for (int j = 0; j < i; j++)
					{
						sumLeft += array[j];
					}
				}
				else
				{
					for (int j = 0; j < i; j++)
					{
						sumLeft += array[j];
					}

					for (int k = i + 1; k < array.Length; k++)
					{
						sumRight += array[k];
					}
				}

				if (sumLeft == sumRight)
				{
					isFound = true;
					break;
				}
			}

			if (isFound)
			{
				Console.WriteLine(midle);
			}
			else
			{
				Console.WriteLine("no");
			}
		}
	}
}
