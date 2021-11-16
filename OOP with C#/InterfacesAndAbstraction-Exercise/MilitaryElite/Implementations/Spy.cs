using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Implementations
{
	public class Spy : ISpy
	{
		public Spy(string id, string firstName, string lastName, int codeNumber)
		{
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			CodeNumber = codeNumber;
		}

		public string Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int CodeNumber { get; set; }
	}
}
