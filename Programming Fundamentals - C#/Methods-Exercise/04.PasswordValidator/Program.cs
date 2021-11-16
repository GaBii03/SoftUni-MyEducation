using System;
using System.Linq;

namespace _04.PasswordValidator
{
	class Program
	{
		static void Main(string[] args)
		{
			string password = Console.ReadLine();

			CheckIfPasswordIsValid(password);
		}

		static void CheckIfPasswordIsValid(string password)
		{
			bool isValidLenght = password.Length >= 6 && password.Length <= 10;
			bool isValidSymbols = password.All(char.IsLetterOrDigit);
			bool containsTwoDigits = password.Count(char.IsDigit) >= 2;

			if (!isValidLenght)
			{
				Console.WriteLine("Password must be between 6 and 10 characters");
			}
			if (!isValidSymbols)
			{
				Console.WriteLine("Password must consist only of letters and digits");
			}
			if (!containsTwoDigits)
			{
				Console.WriteLine("Password must have at least 2 digits");
			}

			if (isValidSymbols && isValidLenght && containsTwoDigits)
			{
				Console.WriteLine("Password is valid");
			}
		}
	}
}
