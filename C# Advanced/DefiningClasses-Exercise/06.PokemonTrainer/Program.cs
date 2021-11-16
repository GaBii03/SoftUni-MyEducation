using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.PokemonTrainer
{
	public class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, Trainer> trainerAndPokemons = new Dictionary<string, Trainer>();
			string command = Console.ReadLine();
			while (command != "Tournament")
			{
				string[] info = command.Split();
				string name = info[0];
				string pokemonName = info[1];
				string element = info[2];
				int pokemonHealth = int.Parse(info[3]);

				Pokemon pokemon = new Pokemon(pokemonName, element, pokemonHealth);

				if (!trainerAndPokemons.ContainsKey(name))
				{
					Trainer newTrainer = new Trainer(name);
					trainerAndPokemons.Add(name, newTrainer);
				}

				Trainer trainer = trainerAndPokemons[name];
				trainer.Pokemons.Add(pokemon);

				command = Console.ReadLine();
			}

			command = Console.ReadLine();

			while (command != "End")
			{
				foreach (var trainer in trainerAndPokemons)
				{
					if (trainer.Value.Pokemons.Any(x => x.Element == command))
					{
						trainer.Value.NumberOfBadges += 1;
					}
					else
					{
						foreach (var pokemon in trainer.Value.Pokemons)
						{
							pokemon.Health -= 10;
						}

						trainer.Value.Pokemons.RemoveAll(x => x.Health <= 0);
					}
				}

				command = Console.ReadLine();
			}
			foreach (var item in trainerAndPokemons.OrderByDescending(t => t.Value.NumberOfBadges))
			{
				Console.WriteLine($"{item.Key} {item.Value.NumberOfBadges} {item.Value.Pokemons.Count}");
			}
		}
	}
}
