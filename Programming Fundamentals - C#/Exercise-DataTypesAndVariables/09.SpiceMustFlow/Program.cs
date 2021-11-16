using System;

namespace _09.SpiceMustFlow
{
	class Program
	{
		static void Main(string[] args)
		{
			int startingYield = int.Parse(Console.ReadLine());
			int extractedSpices = startingYield ;
			int counterDays = 0;
			int totalSpices = 0;
			while (extractedSpices>=100) 
			{
				totalSpices += extractedSpices-26;
				counterDays++;
				extractedSpices -= 10;
				
			}

			if (totalSpices>=26)
			{
				totalSpices -= 26;
			}
			
			Console.WriteLine(counterDays);
			Console.WriteLine(totalSpices);
		}
	}
}
