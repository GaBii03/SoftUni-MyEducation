using BorderControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.Implementations
{
	public class Pet : IPet
	{
		public Pet(string name, string birthday)
		{
			Name = name;
			Birthday = birthday;
		}

		public string Name { get; set; }
		public string Birthday { get; set; }
	}
}
