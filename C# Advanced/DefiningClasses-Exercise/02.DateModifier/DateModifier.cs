using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
	public class DateModifier
	{
		public static int Calculating (string first, string second)
		{
			DateTime dateOne = DateTime.Parse(first);
			DateTime dateTwo = DateTime.Parse(second);

			int days = Math.Abs((dateOne - dateTwo).Days);

			return days;
		}
	}
}
