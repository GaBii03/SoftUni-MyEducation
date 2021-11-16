using System;
using System.Collections.Generic;

namespace WildFarm
{
	public class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			List<IAnimal> animals = new List<IAnimal>();

			while (input != "End")
			{
				string[] animalInfo = input.Split();
				string animalType = animalInfo[0];
				string animalName = animalInfo[1];
				double animalWeigh = double.Parse(animalInfo[2]);

				string[] foodInfo = Console.ReadLine().Split();
				string typeFood = foodInfo[0];
				int amount = int.Parse(foodInfo[1]);


				if (animalType == "Owl")
				{
					double wingSize = double.Parse(animalInfo[3]);
					IAnimal animal = new Owl(animalName, animalWeigh, wingSize);
					animal.ProduceSound();

					if (typeFood == "Meat")
					{
						animal.FoodEaten += amount;
						animal.Weight += amount * 0.25;
					}
					else
					{
						Console.WriteLine($"{animalType} does not eat {typeFood}!");
					}

					animals.Add(animal);
				}
				else if (animalType == "Hen")
				{
					double wingSize = double.Parse(animalInfo[3]);
					IAnimal animal = new Hen(animalName, animalWeigh, wingSize);
					animal.ProduceSound();
					animal.FoodEaten += amount;
					animal.Weight += amount * 0.35;
					animals.Add(animal);
				}
				else if (animalType == "Mouse")
				{
					string livingRegion = animalInfo[3];
					IAnimal animal = new Mouse(animalName, animalWeigh, livingRegion);
					animal.ProduceSound();

					if (typeFood == "Fruit" || typeFood == "Vegetable")
					{
						animal.FoodEaten += amount;
						animal.Weight += amount * 0.10;
					}
					else
					{
						Console.WriteLine($"{animalType} does not eat {typeFood}!");
					}

					animals.Add(animal);

				}
				else if (animalType == "Dog")
				{
					string livingRegion = animalInfo[3];
					IAnimal animal = new Dog(animalName, animalWeigh, livingRegion);
					animal.ProduceSound();

					if (typeFood == "Meat")
					{
						animal.FoodEaten += amount;
						animal.Weight += amount * 0.40;
					}
					else
					{
						Console.WriteLine($"{animalType} does not eat {typeFood}!");
					}

					animals.Add(animal);
				}
				else if (animalType == "Cat")
				{
					string livingRegion = animalInfo[3];
					string breed = animalInfo[4];
					IAnimal animal = new Cat(animalName, animalWeigh, livingRegion, breed);
					animal.ProduceSound();

					if (typeFood == "Meat" || typeFood == "Vegetable")
					{
						animal.FoodEaten += amount;
						animal.Weight += amount * 0.30;
					}
					else
					{
						Console.WriteLine($"{animalType} does not eat {typeFood}!");
					}

					animals.Add(animal);
				}
				else if (animalType == "Tiger")
				{
					string livingRegion = animalInfo[3];
					string breed = animalInfo[4];
					IAnimal animal = new Tiger(animalName, animalWeigh, livingRegion, breed);
					animal.ProduceSound();

					if (typeFood == "Meat")
					{
						animal.FoodEaten += amount;
						animal.Weight += amount;
					}
					else
					{
						Console.WriteLine($"{animalType} does not eat {typeFood}!");
					}

					animals.Add(animal);
				}
				
				input = Console.ReadLine();
			}

			foreach (var animal in animals)
			{
				Console.WriteLine(animal);
			}
		}
	}
}
