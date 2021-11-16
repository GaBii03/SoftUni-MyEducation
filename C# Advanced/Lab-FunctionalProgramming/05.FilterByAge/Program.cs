using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FilterByAge
{
	class Person
	{
		public string FirstName;
		public int Age;
	}
	class Program
	{
		static void Main(string[] args)
		{
			List<Person> people = new List<Person>();
			int n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				var line = Console.ReadLine().Split(", ");
				var person = new Person();
				person.FirstName = line[0];
				person.Age = int.Parse(line[1]);
				people.Add(person);
			}
			string command = Console.ReadLine();
			int age = int.Parse(Console.ReadLine());
			
			Func<Person, bool> filter = p => true;
			if (command=="older")
			{
				filter = p => p.Age > age;
			}
			else if (command=="younger")
			{
				filter = p => p.Age < age;
			}

			var filteredPeople = people.Where(filter);
			Func<Person, string> printFunc = p => p.FirstName + " - " + p.Age;
			string format = Console.ReadLine();
			switch (format)
				{
					case "name age":
					printFunc = p => p.FirstName + " - " + p.Age;
						break;
					case "age":
					printFunc = p => p.Age.ToString();
						break;
					case "name":
					printFunc = p => p.FirstName;
						break;
				}
			var personAsString = filteredPeople.Select(printFunc);
			foreach (var item in personAsString)
			{
				Console.WriteLine(item);
			}

		}
	}
}
