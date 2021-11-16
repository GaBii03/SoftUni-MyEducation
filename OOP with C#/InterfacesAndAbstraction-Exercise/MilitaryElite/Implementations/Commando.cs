using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Implementations
{
	class Commando : ICommando
	{
		public Commando( string id, string firstName, string lastName,decimal salary, Corps corps, List<IMisson> missons)
		{
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			Salary = salary;
			Corps = corps;
			Missons = missons;
		}

		public string Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public decimal Salary { get; set; }
		public Corps Corps { get; set; }
		public List<IMisson> Missons { get; set; }
	}
}
