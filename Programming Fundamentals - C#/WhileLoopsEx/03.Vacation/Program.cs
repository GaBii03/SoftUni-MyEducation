using System;

namespace _03.Vacation
{
	class Program
	{
		static void Main(string[] args)
		{
			double target = double.Parse(Console.ReadLine());
			double budget = double.Parse(Console.ReadLine());
			int days = 0;
			int spentDaysCounter = 0;
			bool saving  = true;
			while (saving)
			{
				string command = Console.ReadLine();
				double amountMoney = double.Parse(Console.ReadLine());
				days++;

				if (command=="save")
				{
					budget += amountMoney;
					spentDaysCounter = 0;
				}
				else
				{
					budget -= amountMoney;
					spentDaysCounter++;
					if (budget<0)
					{
						budget = 0;
					}
				}

				if (spentDaysCounter == 5)
				{
					break;
				}

				if (budget>=target)
				{
					saving = false;
				}

			}
			if (saving==false)
			{
				Console.WriteLine($"You saved the money for {days} days.");
			}
			else
			{
				Console.WriteLine("You can't save the money.");
				Console.WriteLine(days);
			}

			
			
		}
	}
}
