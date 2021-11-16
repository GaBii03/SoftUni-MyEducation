using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.Interfaces
{
	interface IBuyer
	{
		public int Food { get; set; }

		public void BuyFood();
	}
}
