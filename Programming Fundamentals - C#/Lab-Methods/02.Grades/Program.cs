﻿using System;

namespace _02.Grades
{
	class Program
	{
		static void Main(string[] args)
		{
			double grade = double.Parse(Console.ReadLine());
			TypeGrade(grade);
		}

		static void TypeGrade(double grade)
		{
			if (grade>5.49)
			{
				Console.WriteLine("Excellent");
			}
			else if (grade>4.49)
			{
				Console.WriteLine("Very good");
			}
			else if (grade>3.49)
			{
				Console.WriteLine("Good");
			}
			else if (grade>2.99)
			{
				Console.WriteLine("Poor");
			}
			else
			{
				Console.WriteLine("Fail");
			}
		}
	}
}
