using System;

namespace _01._Ages
{
	class Program
	{
		static void Main(string[] args)
		{
			int ages = int.Parse(Console.ReadLine());
			string output = "";
			if (ages>=66)
			{
				output = "elder";
			}
			else if (ages>=20)
			{
				output = "adult";
			}
			else if (ages>=14)
			{
				output = "teenager";
			}
			else if (ages>=3)
			{
				output = "child";
			}
			else if (ages>=0)
			{
				output = "baby";
			}

			Console.WriteLine(output);
		}
	}
}
