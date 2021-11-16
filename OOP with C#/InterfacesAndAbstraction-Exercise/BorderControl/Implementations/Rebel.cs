using BorderControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.Implementations
{
	public class Rebel : IRebel
	{
		public Rebel(string name, int age, string group)
		{
			Name = name;
			Age = age;
			Group = group;
		}

		public string Name { get; set; }
		public int Age { get; set; }
		public string Group { get; set; }
	}
}
