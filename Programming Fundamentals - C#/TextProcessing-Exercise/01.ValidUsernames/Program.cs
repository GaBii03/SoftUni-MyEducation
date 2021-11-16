using System;

namespace _01.ValidUsernames
{
	class Program
	{
		static void Main(string[] args)
		{
			
			string[] input = Console.ReadLine().Split(", ");

			for (int i = 0; i < input.Length; i++)
			{
				bool isValid = true;
				if (input[i].Length >= 3 && input[i].Length <= 16)
				{
					for (int j = 0; j < input[i].Length; j++)
					{
						if (char.IsDigit(input[i][j]) || char.IsLetter(input[i][j]) || input[i][j] == '-' || input[i][j] == '_')
						{
							isValid = true;
							
						}
						else
						{
							isValid = false;
							break;
						}
					}
				}
				else
				{
					isValid = false;
					continue;

				}

				if (isValid)
				{
					Console.WriteLine(input[i]);
				}
			}
		}
	}
}
