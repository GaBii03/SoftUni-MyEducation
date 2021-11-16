using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces
{
	interface IMisson
	{
		public string CodeName { get; set; }
		public State State { get; set; }

		public void CompleteMisson();
	}
}
