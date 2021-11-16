﻿using System;

namespace _01.SignOfIntegerNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			TypeSign(n);
		}

		static void TypeSign(int n)
		{
			if (n>0)
			{
				Console.WriteLine($"The number {n} is positive.");
			}
			else if (n<0)
			{
				Console.WriteLine($"The number {n} is negative.");
			}
			else
			{
				Console.WriteLine($"The number {n} is zero.");
			}
		}
	}
}
