using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
	interface IHero
	{
		public string Name { get; set; }
		public int Power { get; set; }

		public string CastAbility();
	}
}
