using System;
using System.Collections.Generic;
using System.Text;

namespace _01.ReverseStrings
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			Stack<char> stack = new Stack<char>();
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < input.Length; i++)
			{
				stack.Push(input[i]);
			}

			string output = string.Empty;
			for (int i = 0; i < input.Length; i++)
			{
				char element = stack.Peek();
				sb.Append(element);
				stack.Pop();
			}

			Console.WriteLine(string.Join(" ", sb));
		}
	}
}
