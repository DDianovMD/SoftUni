using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= n; rows++)
            {
                for (int columns = 1; columns <= rows; columns++)
                {
                    if (columns < rows)
                    {
                        Console.Write($"{rows} ");
                    }
                    else
                    {
                        Console.WriteLine(rows);
                    }                   
                }
            }
        }
    }
}