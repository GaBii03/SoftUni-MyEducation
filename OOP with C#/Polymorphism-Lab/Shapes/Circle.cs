using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
	public class Circle : Shape
	{
		private int radius;

		public Circle(int radius)
		{
			this.radius = radius;
		}

		public override double CalculateArea()
		{
			return Math.PI * radius * radius;
		}

		public override double CalculatePerimeter()
		{
			return Math.PI * 2 * radius;
		}
	}
}
