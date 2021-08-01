using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = Console.ReadLine();
            string enterPassword = Console.ReadLine();

            while (enterPassword != password)
            {
                enterPassword = Console.ReadLine();
            }
            Console.WriteLine("Welcome {0}!", userName);
        }
    }
}