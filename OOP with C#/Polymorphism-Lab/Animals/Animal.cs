﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
	public class Animal
	{
		public Animal(string name, string favouriteFood)
		{
			Name = name;
			FavouriteFood = favouriteFood;
		}

		public string Name { get; set; }
		public string FavouriteFood { get; set; }

		public virtual StringBuilder ExplainSelf()
		{
			return null; ;
		}
	}
}