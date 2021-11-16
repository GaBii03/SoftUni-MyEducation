using System;

namespace _09.GreaterOfTwoValues
{
	class Program
	{
		static void Main(string[] args)
		{
			string type = Console.ReadLine();
			string valueOne = Console.ReadLine();
			string valueTwo = Console.ReadLine();


			if (type == "string")
			{
				string result = GetMax(valueOne, valueTwo);
				Console.WriteLine(result);
			}
			else if (type == "char")
			{
				char firstChar = char.Parse(valueOne);
				char secondChar = char.Parse(valueTwo);
				char result = GetMax(firstChar, secondChar);
				Console.WriteLine(result);

			}
			else if (type == "int")
			{
				int firstInt = int.Parse(valueOne);
				int secondInt = int.Parse(valueTwo);
				int result = GetMax(firstInt, secondInt);
				Console.WriteLine(result);
			}
		}

		static int GetMax(int firstInt, int secondInt)
		{
			
			if (firstInt > secondInt)
			{
				return firstInt;
			}
			
			return secondInt;
		}

		static string GetMax(string valueOne, string valueTwo)
		{
			int result = valueOne.CompareTo(valueTwo);
			
			if (result > 0)
			{
				return valueOne;
			}
			return valueTwo;
		}

		static char GetMax(char firstChar, char secondChar)
		{
			if (firstChar>secondChar)
			{
				return firstChar;
			}
			return secondChar;
		}
	}
}
