using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
	interface IFood
	{
		public int Quantity { get; set; }

		public TypeFood Food { get; set; }
	}
}
