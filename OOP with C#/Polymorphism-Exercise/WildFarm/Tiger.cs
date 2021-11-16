using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
	public class Tiger : Feline
	{
		public Tiger(string name, double weight, string livingRegion, string breed)
			: base(name, weight, livingRegion, breed)
		{
		}

		public override void ProduceSound()
		{
			Console.WriteLine("ROAR!!!");
		}

		public override string ToString()
		{
			string output = $"Tiger [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
			return output;
		}
	}
}
