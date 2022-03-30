using System;
using System.Linq;

namespace _ListyIterator
{
    public class Program
    {
        static void Main(string[] args)
        {
                        
            var collection = Console.ReadLine()
                                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                    .ToList();
           
            collection.RemoveAt(0);

            ListyIterator<string> iterator = new ListyIterator<string>(collection);

            string command = Console.ReadLine();

            while (command != "END")
            {
                if (command.ToLower() == "move")
                {
                    Console.WriteLine(iterator.Move());
                }
                else if (command.ToLower() == "print")
                {                    
                    try
                    {
                        iterator.Print();
                    }
                    catch (InvalidOperationException)
                    {
                        Console.WriteLine("Invalid Operation!");
                    }                    
                }
                else if (command.ToLower() == "hasnext")
                {
                    Console.WriteLine(iterator.HasNext());
                }
                else if (command.ToLower() == "printall")
                {
                    iterator.PrintAll();
                }

                command = Console.ReadLine();
            }
        }
    }
}
