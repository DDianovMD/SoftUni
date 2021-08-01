using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadText
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            while (text != "Stop")
            {
                Console.WriteLine(text);
                text = Console.ReadLine();
            }
        }
    }
}