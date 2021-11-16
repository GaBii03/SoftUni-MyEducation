using System;

namespace _07.PredicateForNames
{
	class Program
	{
		static void Main(string[] args)
		{
			Func<string, int, bool> isInBound = (name, lenght) => name.Length <= lenght;
			int lenght = int.Parse(Console.ReadLine());
			string[] names = Console.ReadLine().Split();

			string[] result = names.Where(x => isInBound(x, lenght)).ToArray();
			Console.WriteLine(string.Join(Environment.NewLine, result));
		}
	}
}
