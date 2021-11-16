using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var regex = @"\+359([ -])2\1[0-9]{3}\1[0-9]{4}";
			var phoneMatches = Regex.Matches(input, regex);

			var matchedPhenes = phoneMatches.Cast<Match>().Select(a => a.Value.Trim());
			Console.WriteLine(string.Join(", ",matchedPhenes));
		}
	}
}
