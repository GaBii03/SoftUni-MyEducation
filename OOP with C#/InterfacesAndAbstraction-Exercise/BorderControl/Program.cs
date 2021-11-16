using BorderControl.Implementations;
using System;
using System.Collections.Generic;

namespace BorderControl
{
	public class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			List<string> rebels = new List<string>();
			List<string> people = new List<string>();
			double food = 0;

			for (int i = 0; i < n; i++)
			{
				string[] inputArr = Console.ReadLine().Split();

				if (inputArr.Length == 4)
				{
					string name = inputArr[0];
					int age = int.Parse(inputArr[1]);
					string id = inputArr[2];
					string birthdate = inputArr[3];
					Person person = new Person(name, age, id, birthdate);
					people.Add(name);
				}
				else if (inputArr.Length == 3)
				{
					string name = inputArr[0];
					int age = int.Parse(inputArr[1]);
					string group = inputArr[2];
					Rebel rebel = new Rebel(name, age, group);
					rebels.Add(name);
				}
			}

			string specName = Console.ReadLine();

			while (specName!="End")
			{
				if (people.Contains(specName))
				{
					food += 10;
				}
				else if (rebels.Contains(specName))
				{
					food += 5;
				}
				specName = Console.ReadLine();
			}

			Console.WriteLine(food);
			
		}
	}
}
