using System;
using System.Linq;

namespace _04.AddVAT
{
	class Program
	{
		static void Main(string[] args)
		{
			var prices = Console.ReadLine().Split(", ").Select(double.Parse).Select(x => 1.2*x);
			foreach (var price in prices)
			{
				Console.WriteLine($"{price:f2}");
			}
			
		}
	}
}
