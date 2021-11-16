using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Implementations
{
	public class Misson : IMisson
	{
		public Misson(string codeName, State state)
		{
			CodeName = codeName;
			State = state;
		}

		public string CodeName { get; set; }
		public State State { get; set; }

		public void CompleteMisson()
		{
			throw new NotImplementedException();
		}
	}
}
