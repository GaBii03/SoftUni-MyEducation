using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
	class Program
	{
		static void Main(string[] args)
		{
			var items = new SortedDictionary<string, int>();
			var junk = new SortedDictionary<string, int>();
			bool isObtained = false;
			while (!isObtained)
			{
				List<string> input = Console.ReadLine().Split().ToList();
				
				for (int i = 1; i < input.Count; i += 2)
				{
					string key = input[i].ToLower();
					
					if (key == "fragments" || key == "shards" || key == "motes")
					{
						string value = input[i - 1];
						if (items.ContainsKey(key))
						{
							items[key] += int.Parse(value);
						}
						else if (true)
						{
							items.Add(key, int.Parse(value));
						}

						if (items[key] >= 250)
						{
							items[key] -= 250;
							if (key == "fragments")
							{
								Console.WriteLine("Valanyr obtained!");
							}
							else if (key == "shards")
							{
								Console.WriteLine("Shadowmourne obtained!");
							}
							else if (key == "motes")
							{
								Console.WriteLine("Dragonwrath obtained!");
							}
							isObtained = true;
							break;
						}
					}
					else
					{
						string value = input[i - 1];
						if (junk.ContainsKey(key))
						{
							junk[key] += int.Parse(value);
						}
						else if (true)
						{
							junk.Add(key, int.Parse(value));
						}

					}

				}
			}

			if (items.Count<3)
			{
				if (!items.ContainsKey("motes"))
				{
					items.Add("motes", 0);
				}
				if (!items.ContainsKey("fragments"))
				{
					items.Add("fragments", 0);
				}
				if (!items.ContainsKey("shards"))
				{
					items.Add("shards", 0);
				}
			}

			foreach (var item in items.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
			{
				Console.WriteLine($"{item.Key}: {item.Value}");
			}

			foreach (var item in junk)
			{
				Console.WriteLine($"{item.Key}: {item.Value}");
			}
		}

	}
}
