using System;
using System.Linq;
namespace _09.PalindromeIntegers
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			while (input != "END")
			{
				bool isPalindrome = IsPalindrome(input);
				Console.WriteLine(isPalindrome);
				input = Console.ReadLine();
			}
		}

		private static bool IsPalindrome(string input)
		{
			string reversedInput = string.Empty;
			for (int i = input.Length - 1; i >= 0; i--)
			{
				reversedInput += input[i];
			}

			if (input==reversedInput)
			{
				return true;
			}
			return false;
		}
	}
}
