using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
	public class Box<T>
	{
		private List<T> items= new List<T>();

		public void Add(T element)
		{
			items.Add(element);
		}
		public int Counter
		{
			get
			{
				return items.Count;
			}
		}

		public T Remove()
		{
			var element = items[items.Count - 1];
			items.RemoveAt(items.Count - 1);
			return element;
		}

	}
}
