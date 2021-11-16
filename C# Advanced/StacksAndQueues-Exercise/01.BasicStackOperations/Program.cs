using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int numbToPush = input[0];
			int numbToPop = input[1];
			int searchedNum = input[2];
			Stack<int> stack = new Stack<int>();
			bool isFound = false;
			int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
			for (int i = 0; i < numbToPush; i++)
			{
				stack.Push(numbers[i]);
				if (stack.Peek() == searchedNum)
				{
					isFound = true;
				}
			}

			for (int j = 1; j <= numbToPop; j++)
			{
				if (stack.Peek() == searchedNum)
				{
					isFound = false;
				}
				stack.Pop();
			}

			if (isFound)
			{
				Console.WriteLine("true");
			}
			else if (stack.Count == 0)
			{
				Console.WriteLine("0");
			}
			else if (!isFound)
			{
				Console.WriteLine(stack.Min());
			}
		}
	}
}
