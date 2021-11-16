using System;
using System.Collections.Generic;

namespace _06.SongsQueue
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] songs = Console.ReadLine().Split(", ");
			Queue<string> list = new Queue<string>();

			for (int i = 0; i < songs.Length; i++)
			{
				list.Enqueue(songs[i]);
			}

			while (list.Count > 0)
			{
				string[] command = Console.ReadLine().Split();
				string action = command[0];
				if (action == "Play")
				{
					list.Dequeue();
				}
				else if (action == "Add")
				{
					string song1 = command[1];
					if (command.Length == 3)
					{
						string song2 = command[2];
						string song = song1 + " " + song2;
						if (!list.Contains(song))
						{
							list.Enqueue(song);
						}
						else
						{
							Console.WriteLine($"{song} is already contained!");
						}
					}
					else if (command.Length == 4)
					{
						string song2 = command[2];
						string song3 = command[3];
						string song = song1 + " " + song2 + " " + song3;
						if (!list.Contains(song))
						{
							list.Enqueue(song);
						}
						else
						{
							Console.WriteLine($"{song} is already contained!");
						}
					}
					else if (command.Length == 5)
					{
						string song2 = command[2];
						string song3 = command[3];
						string song4 = command[4];
						string song = song1 + " " + song2 + " " + song3 + " " + song4;
						if (!list.Contains(song))
						{
							list.Enqueue(song);
						}
						else
						{
							Console.WriteLine($"{song} is already contained!");
						}
					}
					else
					{
						if (!list.Contains(song1))
						{
							list.Enqueue(song1);
						}
						else
						{
							Console.WriteLine($"{song1} is already contained!");
						}
					}


				}
				else if (action == "Show")
				{
					Console.WriteLine(string.Join(", ", list));
				}
			}
			Console.WriteLine("No more songs!");
		}
	}
}
