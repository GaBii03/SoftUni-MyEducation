using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
	public class Person
	{

		public Person(string firstName, string lastName, int age)
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
		}

		public string FirstName 
		{ 
			get => FirstName; 

			private set => FirstName = value; 
		}

		public string LastName
		{
			get => LastName;

			private set => LastName = value;
		}

		public int Age
		{
			get => Age;

			private set => Age = value;
		}

		
		public override string ToString()
		{
			return $"{FirstName} {LastName} is {Age} years old.";
		}

	}
}
