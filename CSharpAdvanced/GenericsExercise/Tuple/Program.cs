using System;
using System.Collections.Generic;

namespace Tuple
{
    public class Program
    {
        public static void Main()
        {
            for (int i = 0; i < 3; i++)
            {
                string command = Console.ReadLine();

                if (i == 0)
                {
                    string[] userInput = command.Split(" ");
                    List<string> list = new List<string> { userInput[0], userInput[1] };

                    MyCustumTupleClass<List<string>, string> tuple1 = new MyCustumTupleClass<List<string>, string>(list, userInput[2]);
                    Console.WriteLine($"{tuple1.FirstItem.ClassItem[0]} {tuple1.FirstItem.ClassItem[1]} -> {tuple1.SecondItem.ClassItem}");
                }
                else if (i == 1)
                {
                    string[] userInput = command.Split(" ");
                    MyCustumTupleClass<string, int> tuple2 = new MyCustumTupleClass<string, int>(userInput[0], int.Parse(userInput[1]));
                    Console.WriteLine($"{tuple2.FirstItem.ClassItem} -> {tuple2.SecondItem.ClassItem}");
                }
                else if (i == 2)
                {
                    string[] userInput = command.Split(" ");
                    MyCustumTupleClass<double, double> tuple3 = new MyCustumTupleClass<double, double>(double.Parse(userInput[0]), double.Parse(userInput[1]));
                    Console.WriteLine($"{tuple3.FirstItem.ClassItem} -> {tuple3.SecondItem.ClassItem}");
                }
            }            
        }
    }
}
