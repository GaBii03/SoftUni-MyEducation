using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int numbToEnqueue = input[0];
			int numbToDequeue = input[1];
			int searchedNum = input[2];
			bool isFound = false;
			Queue<int> queue = new Queue<int>();
			int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
			for (int i = 0; i < numbToEnqueue; i++)
			{
				queue.Enqueue(numbers[i]);
				if (numbers[i] == searchedNum)
				{
					isFound = true;
				}
			}

			for (int j = 0; j < numbToDequeue; j++)
			{
				if (numbers[j] == searchedNum)
				{
					isFound = false;
				}
				queue.Dequeue();
			}

			if (isFound)
			{
				Console.WriteLine("true");
			}
			else if (queue.Count == 0)
			{
				Console.WriteLine("0");
			}
			else if (!isFound)
			{
				Console.WriteLine(queue.Min());
			}
		}
	}
}
