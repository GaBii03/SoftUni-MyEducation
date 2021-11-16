using System;

namespace _01.SmallestOfThreeNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int c = int.Parse(Console.ReadLine());

			CheckWhichIsSmallest(a, b, c);
		}

		private static void CheckWhichIsSmallest(int a, int b, int c)
		{
			if (a<b && a<c)
			{
				Console.WriteLine(a);
			}
			else if (b<a && b<c)
			{
				Console.WriteLine(b);
			}
			else 
			{
				Console.WriteLine(c);
			}
		}
	}
}
