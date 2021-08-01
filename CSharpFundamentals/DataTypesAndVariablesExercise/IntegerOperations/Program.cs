using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInteger = int.Parse(Console.ReadLine());
            int secondInteger = int.Parse(Console.ReadLine());
            int thirdInteger = int.Parse(Console.ReadLine());
            int fourthInteger = int.Parse(Console.ReadLine());

            int result = ((firstInteger + secondInteger) / thirdInteger) * fourthInteger;

            Console.WriteLine(result);
        }
    }
}