using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
	public class Cat : Feline
	{
		public Cat(string name, double weight, string livingRegion, string breed)
			: base(name, weight, livingRegion, breed)
		{
		}

		public override void ProduceSound()
		{
			Console.WriteLine("Meow");
		}

		public override string ToString()
		{
			string output = $"Cat [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
			return output;
		}
	}
}
