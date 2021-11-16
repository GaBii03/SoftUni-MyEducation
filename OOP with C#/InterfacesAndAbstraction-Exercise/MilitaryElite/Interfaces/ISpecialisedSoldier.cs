using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces
{
	interface ISpecialisedSoldier:IPrivate
	{
		public Corps Corps { get; set; }
	}
}
