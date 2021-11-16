using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
	public class StartUp
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			Family family = new Family();
			for (int i = 0; i < n; i++)
			{
				string[] memberInfo = Console.ReadLine().Split();
				string name = memberInfo[0];
				int age = int.Parse(memberInfo[1]);
				Person currPerson = new Person(name, age);
				family.AddMember(currPerson);
			}

			List<Person> newList = family.People.FindAll(x => x.Age > 30).OrderBy(x => x.Name).ToList();
			foreach (var person in newList)
			{
				Console.WriteLine($"{person.Name} - {person.Age}");
			}
			
		}
	}
}
