using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int capacity = int.Parse(Console.ReadLine());
			Stack<int> stack = new Stack<int>();

			for (int i = input.Length-1; i >= 0; i--)
			{
				stack.Push(input[i]);
			}
			int sum = 0;
			int counter = 1;

			for (int i = 0; i < input.Length; i++)
			{
				int currItem = stack.Peek();
				if (sum+currItem<capacity || sum+currItem==capacity)
				{
					sum += currItem;
				}
				else
				{
					counter++;
					sum = 0;
					sum += currItem;
				}
				stack.Pop();
			}

			Console.WriteLine(counter);
		}
	}
}
