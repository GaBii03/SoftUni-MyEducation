﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
	public class Mouse : Mammal
	{
		public Mouse(string name, double weight, string livingRegion)
			: base(name, weight, livingRegion)
		{
		}

		public override void ProduceSound()
		{
			Console.WriteLine("Squeak");
		}

		public override string ToString()
		{
			string output = $"Mouse [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
			return output;
		}
	}
}
