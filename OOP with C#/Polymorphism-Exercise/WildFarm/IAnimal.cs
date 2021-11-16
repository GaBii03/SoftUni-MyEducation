using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
	interface IAnimal
	{
		public string Name { get; set; }

		public double Weight { get; set; }

		public int FoodEaten { get; set; }

		public void ProduceSound();
	}
}
