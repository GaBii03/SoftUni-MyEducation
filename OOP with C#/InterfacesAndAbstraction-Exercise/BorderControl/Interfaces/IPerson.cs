using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.Interfaces
{
	public interface IPerson
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public string Id { get; set; }
		public string Birthday { get; set; }
	}
}
