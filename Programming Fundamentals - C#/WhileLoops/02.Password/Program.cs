using System;

namespace _02.Password
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = Console.ReadLine();
			string corectPassword = Console.ReadLine();

			string yourInput = Console.ReadLine();
			while (yourInput!= corectPassword)
			{
				yourInput = Console.ReadLine();
			}

			Console.WriteLine($"Welcome {name}!");
		}
	}
}
