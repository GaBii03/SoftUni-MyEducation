using System;
using System.Collections.Generic;

namespace _04.Orders
{
	class Program
	{
		static void Main(string[] args)
		{
			string command = Console.ReadLine();
			var items = new Dictionary<string, double>();
			while (command!="buy")
			{
				string[] commandArr = command.Split();
				string item = commandArr[0];
				double price = double.Parse(commandArr[1]);
				int quantity = int.Parse(commandArr[2]);
			}
		}
	}
}
