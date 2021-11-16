using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
	public class StationaryPhone : IStationaryphone
	{
		public void Dialing(string number)
		{
			Console.WriteLine($"Dialing... {number}");
		}
	}
}
