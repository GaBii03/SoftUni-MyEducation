using System;

namespace OldBooks
{
	class Program
	{
		static void Main(string[] args)
		{
			string nameSearchedBook = Console.ReadLine();
			string currentBook = Console.ReadLine();
			int books = 0;
			while (currentBook!= "No More Books")
			{
				if (currentBook==nameSearchedBook)
				{
					Console.WriteLine($"You checked {books} books and found it.");
					Environment.Exit(0);
				}
				currentBook = Console.ReadLine();
				books++;
			}
			Console.WriteLine("The book you search is not here!");
			Console.WriteLine($"You checked {books} books.");
		}
	}
}
