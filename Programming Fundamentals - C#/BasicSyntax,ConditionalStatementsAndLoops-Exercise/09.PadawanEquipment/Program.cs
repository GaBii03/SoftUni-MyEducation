using System;

namespace _09.PadawanEquipment
{
	class Program
	{
		static void Main(string[] args)
		{
			double budget = double.Parse(Console.ReadLine());
			int numberStudents = int.Parse(Console.ReadLine());
			double pricePerOneLightsaber = double.Parse(Console.ReadLine());
			double pricePerOneRobe = double.Parse(Console.ReadLine());
			double pricePerOneBelt = double.Parse(Console.ReadLine());

			double neededMoney = pricePerOneLightsaber * (Math.Ceiling(numberStudents * 1.1)) + pricePerOneRobe * numberStudents + pricePerOneBelt * (numberStudents - numberStudents/6);

			if (neededMoney<=budget)
			{
				Console.WriteLine($"The money is enough - it would cost {neededMoney:f2}lv.");
			}
			else
			{
				Console.WriteLine($"John will need {neededMoney-budget:f2}lv more.");
			}

		}
	}
}
