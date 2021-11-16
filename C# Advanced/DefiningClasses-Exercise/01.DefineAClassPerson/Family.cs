﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
	public class Family
	{
		public List<Person> People { get; set; }

		public Family()
		{
			People = new List<Person>();
		}

		public void AddMember(Person person) 
		{
			People.Add(person);
		}

		public Person GetOldestMember()
		{
			Person oldestMember = People.OrderByDescending(x => x.Age).FirstOrDefault();
			return oldestMember;
		}

	}
}
