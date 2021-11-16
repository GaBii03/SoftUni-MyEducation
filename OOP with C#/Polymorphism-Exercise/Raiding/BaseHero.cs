using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
	public abstract class BaseHero : IHero
	{
		public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int Power { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public string CastAbility()
		{
			throw new NotImplementedException();
		}
	}
}
