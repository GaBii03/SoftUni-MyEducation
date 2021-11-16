using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Implementations
{
	public class SpecialisedSoldier : ISpecialisedSoldier
	{
		public SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, Corps corps)
		{
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			Salary = salary;
			Corps = corps;
		}

		public string Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public decimal Salary { get; set; }
		public Corps Corps { get; set; }
	}
}
