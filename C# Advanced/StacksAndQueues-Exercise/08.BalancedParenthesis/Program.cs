using System;
using System.Collections.Generic;

namespace _08.BalancedParenthesis
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			Stack<char> parantheses = new Stack<char>();
			bool isBlanced = true;

			foreach (var symbol in input)
			{
				if (symbol=='{' || symbol== '[' || symbol=='(')
				{
					parantheses.Push(symbol);
				}
				else
				{
					if (parantheses.Count==0)
					{
						isBlanced = false;
						break;
					}

					if (symbol == '}' && parantheses.Peek()=='{')
					{
						parantheses.Pop();
					}
					else if (symbol == ']' && parantheses.Peek() == '[')
					{
						parantheses.Pop();
					}
					else if (symbol == ')' && parantheses.Peek() == '(')
					{
						parantheses.Pop();
					}
					else
					{
						isBlanced = false;
					}
				}
			}

			if (isBlanced)
			{
				Console.WriteLine("YES");
			}
			else 
			{
				Console.WriteLine("NO");
			}
		}
	}
}
