using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs
{
    public class Song
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

        public Song(string[] song)
        {
            this.Type = song[0];
            this.Name = song[1];
            this.Time = song[2];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Song> playList = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] cuurentSong = Console.ReadLine()
                                .Split("_", StringSplitOptions.RemoveEmptyEntries)
                                .ToArray();

                Song mySong = new Song(cuurentSong);

                playList.Add(mySong);
            }

            string command = Console.ReadLine();

            if (command == "all")
            {
                foreach (var song in playList)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in playList)
                {
                    if (song.Type == command)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}
