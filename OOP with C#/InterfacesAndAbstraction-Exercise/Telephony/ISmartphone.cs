using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
	public interface ISmartphone
	{
		public void Calling(string number);
		public void Browsing(string website);
	}
}
