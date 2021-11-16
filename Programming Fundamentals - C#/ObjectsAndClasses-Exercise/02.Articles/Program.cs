using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Articles
{
	class Program
	{
		static void Main(string[] args)
		{
			List <string> input = Console.ReadLine().Split(", ").ToList();

			Article article = new Article(input[0], input[1], input[2]);

			int n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				string command = Console.ReadLine();
				string[] splitted = command.Split(": ");
				string commandName = splitted[0];
				string commandValue = splitted[1];

				if (commandName == "Edit")
				{
					article.Edit(commandValue);
				}
				else if (commandName == "Rename")
				{
					article.Rename(commandValue);
				}
				else if (commandName == "ChangeAuthor")
				{
					article.ChangeAuthor(commandValue);
				}
			}

			Console.WriteLine(article);
		}
	}

	
}
