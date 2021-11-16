using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
	class Program
	{
		static void Main(string[] args)
		{
			int food = int.Parse(Console.ReadLine());
			Queue<int> queue = new Queue<int>();
			int biggestOrder = int.MinValue;
			int[] customers = Console.ReadLine().Split().Select(int.Parse).ToArray();
			for (int i = 0; i < customers.Length; i++)
			{
				if (customers[i]>biggestOrder)
				{
					biggestOrder = customers[i];
				}
				queue.Enqueue(customers[i]);
			}
			bool isEnough = true;
			for (int i = 0; i < customers.Length; i++)
			{
				if (food>=queue.Peek())
				{
					food -= queue.Peek();
					queue.Dequeue();
				}
				else
				{
					isEnough = false;
					break;
				}
			}

			if (isEnough)
			{
				Console.WriteLine(biggestOrder);
				Console.WriteLine("Orders complete");
			}
			else
			{
				Console.WriteLine(biggestOrder);
				Console.Write("Orders left: ");
				for (int i = 0; i < queue.Count; i++)
				{
					Console.Write($"{queue.Peek()} ");
				}
			}
		}
	}
}
