using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.WordSynonyms
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			var synonymWords = new Dictionary<string, List<string>>();
			for (int i = 0; i < n; i++)
			{
				string word = Console.ReadLine();
				string synonym = Console.ReadLine();
				if (!synonymWords.ContainsKey(word))
				{
					synonymWords.Add(word, new List<string>());
				}
				synonymWords[word].Add(synonym);
			}

			foreach (var word in synonymWords)
			{
				Console.WriteLine(word);
				//Console.WriteLine($"{word.Key} - {}");
			}
		}
	}
}
