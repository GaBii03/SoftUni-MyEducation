using System;
using System.Linq;

namespace Telephony
{
	public class StartUp
	{
		static void Main(string[] args)
		{
			string[] phoneNumbers = Console.ReadLine().Split();
			string[] websites = Console.ReadLine().Split();

			for (int i = 0; i < phoneNumbers.Length; i++)
			{
				string currentNumber = phoneNumbers[i];

				if (currentNumber.Length == 7)
				{
					StationaryPhone stationaryPhone = new StationaryPhone();
					stationaryPhone.Dialing(currentNumber);
				}
				else if (currentNumber.Length == 10)
				{
					Smartphone smarthone = new Smartphone();
					smarthone.Calling(currentNumber);
				}
				else
				{
					Console.WriteLine("Invalid number!");
				}

			}

			for (int i = 0; i < websites.Length; i++)
			{
				string currentWeb = websites[i];
				bool isValidWeb = true;
				for (int j = 0; j < currentWeb.Length; j++)
				{
					if (currentWeb[j] == '0' || currentWeb[j] == '1' || currentWeb[j] == '2' || currentWeb[j] == '3' ||
						currentWeb[j] == '4' || currentWeb[j] == '5' || currentWeb[j] == '6' || currentWeb[j] == '7' ||
						currentWeb[j] == '8' || currentWeb[j] == '9')
					{
						isValidWeb = false;
						break;
					}
				}

				if (isValidWeb)
				{
					Smartphone smarthone = new Smartphone();
					smarthone.Browsing(currentWeb);
				}
				else
				{
					Console.WriteLine("Invalid URL!");
				}
			}

		}
	}
}
