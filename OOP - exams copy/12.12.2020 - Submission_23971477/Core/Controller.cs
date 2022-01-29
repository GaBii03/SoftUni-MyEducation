using Bakery.Core.Contracts;
using Bakery.Models.BakedFoods;
using Bakery.Models.BakedFoods.Contracts;
using Bakery.Models.Drinks;
using Bakery.Models.Drinks.Contracts;
using Bakery.Models.Tables;
using Bakery.Models.Tables.Contracts;
using Bakery.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bakery.Core
{
	public class Controller : IController
	{
		private List<IBakedFood> bakedFoods;
		private List<IDrink> drinks;
		private List<ITable> tables;
		private decimal totalIncome;

		public Controller()
		{
			bakedFoods = new List<IBakedFood>();
			drinks = new List<IDrink>();
			tables = new List<ITable>();
			totalIncome = 0;
		}

		public string AddDrink(string type, string name, int portion, string brand)
		{
			IDrink drink = default;
			if (type == "Tea")
			{
				drink = new Tea(name, portion, brand);
			}
			else if (type == "Water")
			{
				drink = new Water(name, portion, brand);
			}

			drinks.Add(drink);
			return string.Format(OutputMessages.DrinkAdded, name, brand);
		}

		public string AddFood(string type, string name, decimal price)
		{
			IBakedFood bakedFood = default;
			if (type == "Cake")
			{
				bakedFood = new Cake(name, price);
			}
			else if (type == "Bread")
			{
				bakedFood = new Bread(name, price);
			}

			bakedFoods.Add(bakedFood);
			return string.Format(OutputMessages.FoodAdded, name, type);
			
		}

		public string AddTable(string type, int tableNumber, int capacity)
		{
			ITable table = default;
			if (type == "OutsideTable")
			{
				table = new OutsideTable(tableNumber, capacity);
			}
			else if (type == "InsideTable")
			{
				table = new InsideTable(tableNumber, capacity);
			}

			tables.Add(table);
			return string.Format(OutputMessages.TableAdded, table);
		}

		public string GetFreeTablesInfo()
		{
			StringBuilder sb = new StringBuilder();
			List<ITable> freeTables = tables.Where(x => !x.IsReserved).ToList();
			foreach (var item in freeTables)
			{
				sb.AppendLine(item.GetFreeTableInfo());
			}

			return sb.ToString().TrimEnd();
		}

		public string GetTotalIncome()
		{
			return string.Format(OutputMessages.TotalIncome, totalIncome);
		}

		public string LeaveTable(int tableNumber)
		{
			decimal bill = 0;
			foreach (var table in tables)
			{
				if (tableNumber == table.TableNumber)
				{
					bill = table.GetBill();
					table.Clear();
				}
			}

			totalIncome += bill;
			return $"Table: {tableNumber}" + Environment.NewLine +
					$"Bill: {bill:f2}";
		}

		public string OrderDrink(int tableNumber, string drinkName, string drinkBrand)
		{
			bool isFound = false;
			bool isExistingDrink = false;
			ITable currTable = null;
			IDrink currDrink = null;
			foreach (var table in tables)
			{
				if (table.TableNumber == tableNumber)
				{
					isFound = true;
					currTable = table;
					break;
				}
			}

			foreach (var drink in drinks)
			{
				if (drinkName == drink.Name && drinkBrand == drink.Brand)
				{
					isExistingDrink = true;
					currDrink = drink;
					break;
				}
			}

			if (!isFound)
			{
				return string.Format(OutputMessages.WrongTableNumber, tableNumber);
			}
			if (!isExistingDrink)
			{
				return string.Format(OutputMessages.NonExistentDrink, drinkName, drinkBrand);
			}

			currTable.OrderDrink(currDrink);
			return $"Table {tableNumber} ordered {drinkName} {drinkBrand}";
		
		}

		public string OrderFood(int tableNumber, string foodName)
		{
			bool isFound = false;
			bool isExistingFood = false;
			ITable currTable = null;
			IBakedFood currBakedFood = null;
			foreach (var table in tables)
			{
				if (table.TableNumber == tableNumber)
				{
					isFound = true;
					currTable = table;
					break;
				}
			}

			foreach (var bakedFood in bakedFoods)
			{
				if (bakedFood.Name == foodName)
				{
					isExistingFood = true;
					currBakedFood = bakedFood;
					break;
				}
			}

			if (!isFound)
			{
				return string.Format(OutputMessages.WrongTableNumber, tableNumber);
			}
			if (!isExistingFood)
			{
				return string.Format(OutputMessages.NonExistentFood, foodName);
			}


			currTable.OrderFood(currBakedFood);
			return string.Format(OutputMessages.FoodOrderSuccessful, tableNumber, foodName);
		}

		public string ReserveTable(int numberOfPeople)
		{
			foreach (var table in tables)
			{
				if (table.IsReserved == false && table.Capacity >= numberOfPeople)
				{
					table.Reserve(numberOfPeople);
					return string.Format(OutputMessages.TableReserved, table.TableNumber, numberOfPeople);
				}
			}

			return string.Format(OutputMessages.ReservationNotPossible, numberOfPeople);
		}
	}
}
