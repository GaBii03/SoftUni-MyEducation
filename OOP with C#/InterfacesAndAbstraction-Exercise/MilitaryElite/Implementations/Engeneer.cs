using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Implementations
{
	class Engeneer : IEngeneer
	{
		public Engeneer(string id, string firstName, string lastName, decimal salary, Corps corps, List<IRepair> repairs)
		{
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			Salary = salary;
			Corps = corps;
			Repairs = repairs;
		}

		public string Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public decimal Salary { get; set; }
		public Corps Corps { get; set; }
		public List<IRepair> Repairs { get; set; }

	}
}
