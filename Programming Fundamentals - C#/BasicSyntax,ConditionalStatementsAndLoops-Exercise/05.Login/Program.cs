using System;

namespace _05.Login
{
	class Program
	{
		static void Main(string[] args)
		{
			string username = Console.ReadLine();
			string password = "";
			int counter = 0;

			for (int i = username.Length - 1; i >= 0; i--)
			{
				password += username[i];
			}

			string givenPassword = Console.ReadLine();
			while (givenPassword!=password)
			{
				counter++;
				if (counter==4)
				{
					Console.WriteLine($"User {username} blocked!");
					return;
				}
				Console.WriteLine("Incorrect password. Try again.");
				givenPassword =Console.ReadLine();
			}
		
	
			Console.WriteLine($"User {username} logged in.");
			
			
		}
	}
}
