using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
	public class Owl : Bird
	{
		public Owl(string name, double weight, double wingSize)
			: base(name, weight, wingSize)
		{
		}

		public override void ProduceSound()
		{
			Console.WriteLine("Hoot Hoot");
		}

		public override string ToString()
		{
			string output = $"Owl [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
			return output;
		}
	}
}
