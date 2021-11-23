using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songsArray = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Queue<string> songsQueue = new Queue<string>();
            Queue<string> tempQueue = new Queue<string>(); // temporary queue used to save songs when showing playlist by dequeue them.

            foreach (var song in songsArray)
            {
                if (songsQueue.Contains(song) == false)
                {
                    songsQueue.Enqueue(song);
                }                
            }
            
            string[] commands = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (songsQueue.Count > 0)
            {
                if (commands[0].ToLower() == "play")
                {
                    songsQueue.Dequeue();

                    // Ignore commands if there aren't songs anymore.
                    if (songsQueue.Count == 0)
                    {
                        break;
                    }
                }
                else if (commands[0].ToLower() == "add")
                {
                    // Build the song's name from the array by ignoring "add" command.

                    StringBuilder song = new StringBuilder();

                    for (int i = 1; i < commands.Length; i++)
                    {
                        if (i < commands.Length - 1)
                        {
                            song.Append($"{commands[i]} ");
                        }
                        else
                        {
                            song.Append($"{commands[i]}");
                        }
                    }
                    
                    // Check if song is already in the queue.
                    if (songsQueue.Contains(song.ToString()) == false)
                    {
                        songsQueue.Enqueue(song.ToString());
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }

                    // Clear the variable which holds the song's name.
                    song.Clear();
                }
                else if (commands[0].ToLower() == "show")
                {
                    // Show songs one by one using Dequeue() method and save them in temporary queue used to recover original queue.
                    for (int i = 0; i < songsQueue.Count; i++)
                    {
                        if (i < songsQueue.Count - 1)
                        {
                            Console.Write($"{songsQueue.Peek()}, ");
                            tempQueue.Enqueue(songsQueue.Peek());
                            songsQueue.Dequeue();
                            i--;
                        }
                        else
                        {
                            Console.WriteLine($"{songsQueue.Peek()}");
                            tempQueue.Enqueue(songsQueue.Peek());
                            songsQueue.Dequeue();
                            i--;
                        }
                    }

                    // Recover original queue of songs.
                    for (int i = 0; i < tempQueue.Count; i++)
                    {
                        songsQueue.Enqueue(tempQueue.Peek());
                        tempQueue.Dequeue();
                        i--;
                    }
                }

                // Read next command.
                commands = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            Console.WriteLine("No more songs!");
        }
    }
}
