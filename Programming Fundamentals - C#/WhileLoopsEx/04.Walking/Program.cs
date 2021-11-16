using System;

namespace _04.Walking
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			int totalSteps = 0;
			while (input!="Going home")
			{
				int currentSteps = int.Parse(input);
				totalSteps += currentSteps;
				if (totalSteps>=10000)
				{
					Console.WriteLine("Goal reached! Good job!");
					Console.WriteLine($"{totalSteps-10000} steps over the goal!");
					break;
				}
				input =Console.ReadLine();
			}

			if (input=="Going home")
			{
				input = Console.ReadLine();
				int currentSteps = int.Parse(input);
				totalSteps += currentSteps;
				if (totalSteps<10000)
				{
					Console.WriteLine($"{10000-totalSteps} more steps to reach goal.");
				}
				else
				{
					Console.WriteLine("Goal reached! Good job!");
					Console.WriteLine($"{totalSteps - 10000} steps over the goal!");
				}
				
				

			}

		}
	}
}
