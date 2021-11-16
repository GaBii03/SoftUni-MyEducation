using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
	public class Hen : Bird
	{
		public Hen(string name, double weight, double wingSize)
			: base(name, weight, wingSize)
		{
		}

		public override void ProduceSound()
		{
			Console.WriteLine("Cluck");
		}

		public override string ToString()
		{
			string output = $"Hen [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
			return output;
		}
	}
}
