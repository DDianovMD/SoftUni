using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            string input = Console.ReadLine();
            int checkedBooksCounter = 0;

            while (input != searchedBook)
            {
                if (input == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {checkedBooksCounter} books.");
                    break;
                }
                checkedBooksCounter += 1;
                input = Console.ReadLine();
            }

            if (input == searchedBook)
            {
                Console.WriteLine($"You checked {checkedBooksCounter} books and found it.");
            }
        }
    }
}