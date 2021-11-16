using System;

namespace _03.ExtractFile
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] path = Console.ReadLine().Split("\\");
			string[] lastPart = path[path.Length - 1].Split(".");
			string name = lastPart[0];
			string extension = lastPart[1];
			Console.WriteLine($"File name: {name}");
			Console.WriteLine($"File extension: {extension}");
		}
	}
}
