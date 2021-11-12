using System;
using System.Collections.Generic;

namespace Task3b
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Type> genres = new List<Type>();
            foreach (Type type in typeof(Song).Assembly.GetTypes())
                if (type.IsSubclassOf(typeof(Song)))
                    genres.Add(type);

            Player player = new Player();
            do
            {
                Console.Clear();
                Console.WriteLine("ADD SONG");
                for (int i = 0; i < genres.Count; i++)
                    Console.WriteLine(i + ". " + genres[i].Name);
                Console.Write("Choose genre: ");
                int n;
                while (!int.TryParse(Console.ReadLine(), out n) || n < 0 || n >= genres.Count) ;
                Console.Write("Author: ");
                string author = Console.ReadLine();
                Console.Write("Title: ");
                string title = Console.ReadLine();
                player.Add((Song)Activator.CreateInstance(genres[n], new[] { author, title }));
                Console.WriteLine("Next song? [N to break]");
            } while (Console.ReadKey(true).Key != ConsoleKey.N);

            Console.Clear();
            Console.WriteLine("PLAYING...");

            while (!player.IsEmpty())
            {
                Console.WriteLine();
                player.Play(0);
                player.Remove(0);
            }
        }
    }
}
