using BorderControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.Implementations
{
	class Person:IPerson
	{
		public Person(string name, int age, string id, string birthday)
		{
			Name = name;
			Age = age;
			Id = id;
			Birthday = birthday;
		}

		public string Name { get; set; }

		public int Age { get; set; }

		public string Id { get; set; }
		public string Birthday { get; set; }
	}
}
