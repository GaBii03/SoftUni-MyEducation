using System;

namespace _06.ReverseAndExclude
{
	class Program
	{
		static void Main(string[] args)
		{
			Func<int, int, bool> isDevisible = (n, m) => n % m == 0;
			int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int num = int.Parse(Console.ReadLine());

			int[] result = numbers.Where(x => !isDevisible(x, num)).Reverse().ToArray();
			Console.WriteLine(string.Join(" ", result));
		}
	}
}
