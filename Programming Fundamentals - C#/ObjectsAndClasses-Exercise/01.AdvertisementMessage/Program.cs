using System;
using System.Collections.Generic;

namespace _01.AdvertisementMessage
{
	class Program
	{
		static void Main(string[] args)
		{
			Messages phrases = new Messages(new List<string>() { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." });
			Messages events = new Messages(new List<string>() { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" });
			Messages authors = new Messages(new List<string>() { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" });
			Messages cities = new Messages(new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" });

			Console.WriteLine($"{phrases.GetRandom()} {events.GetRandom()} {authors.GetRandom()} – {cities.GetRandom()}.");
		}
	}
}
