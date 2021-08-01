using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();           
            string reversedUsername = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--) // обръща username за сравнение на паролата.
            {
                reversedUsername += username[i];
            }

            int counter = 0; // брой опити за login в системата.

            while (true)
            {
                string password = Console.ReadLine();
                counter++;
                if (password == reversedUsername)
                {
                    Console.WriteLine($"User {username} logged in.");
                    Environment.Exit(0);
                }
                else if (password != reversedUsername && counter == 4) // ако паролата на четвъртия опит е неправилна - блокира user-а.
                {
                    Console.WriteLine($"User {username} blocked!");
                    Environment.Exit(0);
                }
                else if (password != reversedUsername)
                {                   
                    Console.WriteLine($"Incorrect password. Try again.");
                }               
            }
        }
    }
}