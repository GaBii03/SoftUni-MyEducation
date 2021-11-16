using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Implementations
{
	public class LieutenantGeneral : ILieutenantGeneral
	{
		public LieutenantGeneral(string id, string firstName, string lastName, decimal salary, List<IPrivate> privates)
		{
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			Salary = salary;
			Privates = privates;
		}

		public string Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public decimal Salary { get; set; }
		public List<IPrivate> Privates { get; set; }
	}
}
