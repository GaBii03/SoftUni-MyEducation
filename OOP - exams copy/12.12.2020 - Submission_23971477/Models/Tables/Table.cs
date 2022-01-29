using Bakery.Models.BakedFoods;
using Bakery.Models.BakedFoods.Contracts;
using Bakery.Models.Drinks;
using Bakery.Models.Drinks.Contracts;
using Bakery.Models.Tables.Contracts;
using Bakery.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bakery.Models.Tables
{
	public abstract class Table : ITable
	{
		private int capacity;
		private int numberOfPeople;
		private List<IBakedFood> foods;
		private List<IDrink> drinks;

		public Table(int tableNumber, int capacity, decimal pricePerPerson)
		{
			this.TableNumber = tableNumber;
			this.Capacity = capacity;
			this.PricePerPerson = pricePerPerson;
			foods = new List<IBakedFood>();
			drinks = new List<IDrink>();
		}

		public int TableNumber { get; private set; }

		public int Capacity
		{
			get => this.capacity;
			private set
			{
				if (value < 0)////// cant be less or what?
				{
					throw new ArgumentException(ExceptionMessages.InvalidTableCapacity);
				}

				this.capacity = value;
			}
		}

		public decimal PricePerPerson { get; private set; }

		public int NumberOfPeople
		{
			get => this.numberOfPeople;
			private set
			{
				if (value <= 0)
				{
					throw new ArgumentException(ExceptionMessages.InvalidNumberOfPeople);
				}

				this.numberOfPeople = value;
			}
		}

		public bool IsReserved { get; protected set; }

		public decimal Price => NumberOfPeople * PricePerPerson;

		public void Clear()
		{
			foods.Clear();
			drinks.Clear();
			IsReserved = false;
			numberOfPeople = 0;
		}

		public decimal GetBill()
		{
			decimal bill = Price ;
			foreach (var drink in drinks)
			{
				bill += drink.Price;
			}

			foreach (var food in foods)
			{
				bill += food.Price;
			}

			return bill;
		}

		public string GetFreeTableInfo()
		{
			return  $"Table: {TableNumber}" + Environment.NewLine +
					$"Type: {this.GetType().Name}" + Environment.NewLine +
					$"Capacity: {Capacity}" + Environment.NewLine +
					$"Price per Person: {PricePerPerson}";
		}

		public void OrderDrink(IDrink drink)
		{
			drinks.Add(drink);
		}

		public void OrderFood(IBakedFood food)
		{
			foods.Add(food);
		}

		public void Reserve(int numberOfPeople)
		{
			this.NumberOfPeople = numberOfPeople;
			IsReserved = true;
		}
	}
}
