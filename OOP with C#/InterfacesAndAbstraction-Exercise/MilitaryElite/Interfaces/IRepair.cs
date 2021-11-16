using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces
{
	interface IRepair
	{
		public string PartName { get; set; }
		public int HoursWorked { get; set; }
	}
}
