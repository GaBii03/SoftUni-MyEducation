using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.ThePartyReservationFilterModule
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> names = Console.ReadLine().Split().ToList();
			var dictionary = new Dictionary<string, Predicate<string>>();

			string commamd = Console.ReadLine();

			while (commamd!= "Print")
			{
				string[] commandArr = commamd.Split(';');
				string action = commandArr[0];
				string predicateAction = commandArr[1];
				string value = commandArr[2];
				string key = predicateAction + "_" + value;

				if (action=="Add filter")
				{
					Predicate<string> predicate = GetPredicate(predicateAction, value);
					dictionary.Add(key, predicate);
				}
				else
				{
					dictionary.Remove(key);
				}

				commamd = Console.ReadLine();
			}

			foreach (var (key, predicate) in dictionary)
			{
				names.RemoveAll(predicate);
			}

			Console.WriteLine(string.Join(" ", names));
		}

		private static Predicate<string> GetPredicate(string commandInfo, string param)
		{
			if (commandInfo == "Starts with")
			{
				return x => x.StartsWith(param);
			}

			if (commandInfo == "Ends with")
			{
				return x => x.EndsWith(param);
			}

			if (commandInfo == "Contains")
			{
				return x => x.Contains(param);
			}

			int length = int.Parse(param);
			return x => x.Length == length;
		}
	}
}
