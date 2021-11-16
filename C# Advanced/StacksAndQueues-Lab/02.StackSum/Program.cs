using System;
using System.Collections.Generic;

namespace _02.StackSum
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			Stack<int> nums = new Stack<int>();
			for (int i = 0; i < input.Length; i+=2)
			{
				int currentNum =input[i]-48;
				nums.Push(currentNum);
			}

			string command = Console.ReadLine().ToLower();
			while (command!="end")
			{
				string[] commandArr = command.Split();
				string action = commandArr[0].ToLower();
				if (action=="add")
				{
					int firstNumber = int.Parse(commandArr[1]);
					nums.Push(firstNumber);
					int secNum = int.Parse(commandArr[2]);
					nums.Push(secNum);

				}
				else if (action=="remove")
				{
					
					int n = int.Parse(commandArr[1]);
					if (n>nums.Count)
					{
						command = Console.ReadLine().ToLower();
						continue;
					}
					for (int i = 0; i < n; i++)
					{
						nums.Pop();
					}
				}
				command = Console.ReadLine().ToLower();
			}
			int sum = 0;
			int interuptions = nums.Count;
			for (int i = 0; i < interuptions; i++)
			{
				int currNum = nums.Peek();
				sum += currNum;
				nums.Pop();
			}
			Console.WriteLine("Sum: " + sum);
		}
	}
}
