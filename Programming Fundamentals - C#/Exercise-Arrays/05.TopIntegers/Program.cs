using System;
using System.Linq;

namespace _05.TopIntegers
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

			for (int i = 0; i < array.Length; i++)
			{
				if (i==array.Length-1)
				{
					Console.Write(array[i]);
					break;
				}
				int counter = 0;
				for (int j = i + 1; j < array.Length; j++)
				{
					if (array[i] > array[j])
					{
						counter++;
						if (counter == (array.Length)-(i+1))
						{
							Console.Write(array[i] + " ");
						}
					}
				}
			}
		}
	}
}
