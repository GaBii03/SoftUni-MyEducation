using System;

namespace _03.Vacation
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberPeople = int.Parse(Console.ReadLine());
			string typeOfGroup = Console.ReadLine();
			string dayOfWeek = Console.ReadLine();

			double pricePerPerson = 0;

			switch (typeOfGroup)
			{
				case "Students":

					switch (dayOfWeek)
					{
						case"Friday":
							pricePerPerson = 8.45;
							break;
						case "Saturday":
							pricePerPerson = 9.80;
							break;
						case "Sunday":
							pricePerPerson = 10.46;
							break;
					}
					break;

				case "Business":

					switch (dayOfWeek)
					{
						case "Friday":
							pricePerPerson = 10.90;
							break;
						case "Saturday":
							pricePerPerson = 15.60;
							break;
						case "Sunday":
							pricePerPerson = 16;
							break;
					}
					break;

				case "Regular":

					switch (dayOfWeek)
					{
						case "Friday":
							pricePerPerson = 15;
							break;
						case "Saturday":
							pricePerPerson = 20;
							break;
						case "Sunday":
							pricePerPerson = 22.50;
							break;
					}
					break;
			}

			double totalPrice = pricePerPerson * numberPeople;

			switch (typeOfGroup)
			{
				case"Students":
					if (numberPeople>=30)
					{
						totalPrice *= 0.85;
					}
					break;
				case "Business":
					if (numberPeople>=100)
					{
						totalPrice -= 10 * pricePerPerson;
					}
					break;
				case "Regular":
					if (numberPeople>=10 && numberPeople<=20)
					{
						totalPrice *= 0.95;
					}
					break;
			}
			Console.WriteLine($"Total price: {totalPrice:f2}");
		}
	}
}
