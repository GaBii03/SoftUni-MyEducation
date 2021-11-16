using System;

namespace _07.VendingMachine
{
	class Program
	{
		static void Main(string[] args)
		{
			string input1 = Console.ReadLine();
			double theMoneyGiven = 0;

			while (input1 != "Start")
			{
				double theCoin = double.Parse(input1);

				switch (theCoin)
				{
					case 0.1:
					case 0.2:
					case 0.5:
					case 1:
					case 2:
						theMoneyGiven += theCoin;
						break;
					default:
						Console.WriteLine($"Cannot accept {theCoin}");
						break;
				}

				input1 = Console.ReadLine();
			}

			string intput2 = Console.ReadLine().ToLower();

			while (intput2 != "end")
			{
				bool isInvalid = false;
				string theProduct = intput2;
				double price = 0;

				switch (theProduct)
				{
					case "nuts":
						price = 2;
						break;
					case "water":
						price = 0.7;
						break;
					case "crisps":
						price = 1.5;
						break;
					case "soda":
						price = 0.8;
						break;
					case "coke":
						price = 1;
						break;
					default:
						Console.WriteLine("Invalid product");
						isInvalid = true;
						break;
				}

				if (!isInvalid)
				{
					theMoneyGiven -= price;

					if (theMoneyGiven < 0)
					{
						Console.WriteLine("Sorry, not enough money");
						theMoneyGiven += price;
				
					}
					else
					{
						Console.WriteLine($"Purchased {theProduct}");
					}
				}

				intput2 = Console.ReadLine().ToLower();
			}

			Console.WriteLine($"Change: {theMoneyGiven:f2}");
		}
	}
}
