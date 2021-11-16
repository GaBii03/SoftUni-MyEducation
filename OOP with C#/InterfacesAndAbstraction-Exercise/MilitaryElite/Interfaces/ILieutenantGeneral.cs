using MilitaryElite.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces
{
	interface ILieutenantGeneral : IPrivate
	{
		public List<IPrivate> Privates { get; set; }
	}
}
