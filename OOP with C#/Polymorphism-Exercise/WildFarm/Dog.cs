using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
	public class Dog : Mammal
	{
		public Dog(string name, double weight, string livingRegion)
			: base(name, weight, livingRegion)
		{
		}

		public override void ProduceSound()
		{
			Console.WriteLine("Woof!");
		}

		public override string ToString()
		{
			string output = $"Dog [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
			return output;
		}
	}
}
