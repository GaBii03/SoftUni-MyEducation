using System;
using System.Linq;

namespace _08.MagicSum
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] givenArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int magicNumber = int.Parse(Console.ReadLine());
			
			for (int i = 0; i < givenArray.Length; i++)
			{
				for (int j = i+1; j < givenArray.Length; j++)
				{
					if (givenArray[i]+givenArray[j]==magicNumber)
					{
						Console.Write($"{givenArray[i]} {givenArray[j]}");
						Console.WriteLine();
					}
				}
			}
		}
	}
}
