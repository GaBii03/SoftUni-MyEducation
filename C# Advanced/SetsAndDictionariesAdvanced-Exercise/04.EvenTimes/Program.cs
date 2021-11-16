using System;
using System.Collections.Generic;

namespace _04.EvenTimes
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			Dictionary<int, int> dic = new Dictionary<int, int>();
			for (int i = 0; i < n; i++)
			{
				int num = int.Parse(Console.ReadLine());
				if (!dic.ContainsKey(num))
				{
					dic.Add(num, new int());
				}

				dic[num] += 1;

			}

			foreach (var item in dic)
			{
				if (item.Value%2==0)
				{
					Console.WriteLine(item.Key);
				}
			}
		}
	}
}
