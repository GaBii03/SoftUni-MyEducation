using System;
using System.Text;

namespace _04.CaesarCipher
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			StringBuilder newInput = new StringBuilder();
			for (int i = 0; i < input.Length; i++)
			{
				newInput.Append((char)(input[i] + 3));
			}

			Console.WriteLine(newInput);
		}
	}
}
