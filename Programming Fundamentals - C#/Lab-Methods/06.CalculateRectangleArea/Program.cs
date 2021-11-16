using System;

namespace _06.CalculateRectangleArea
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());

			int area = CalculateRectangleArea(a, b);
			Console.WriteLine(area);
		}

		static int CalculateRectangleArea(int a, int b)
		{
			int area = a * b;
			return area;
		}
	}
}
