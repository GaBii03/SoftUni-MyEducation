using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Implementations
{
	public class Private : IPrivate
	{
		public Private(string id, string firstName, string lastName, decimal salary)
		{
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			Salary = salary;
		}

		public string Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public decimal Salary { get; set; }
	}
}
