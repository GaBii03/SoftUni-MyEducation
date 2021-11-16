using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces
{
	interface ICommando:ISpecialisedSoldier
	{
		public List<IMisson> Missons { get; set; }
	}
}
