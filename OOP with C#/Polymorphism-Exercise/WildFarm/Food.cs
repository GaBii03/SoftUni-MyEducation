using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
	public class Foods : IFood
	{
		public Foods(int quantity, TypeFood food)
		{
			Quantity = quantity;
			Food = food;
		}

		public int Quantity { get ; set ; }
		public TypeFood Food { get ; set ; }
	}
}
