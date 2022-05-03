using System;
using System.Collections.Generic;

namespace Threeuple
{
    public class Program
    {
        static void Main()
        {            
            for (int i = 0; i < 3; i++)
            {
                string[] userInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (i == 0)
                {
                    var item1 = new List<string> { userInput[0], userInput[1] };
                    var item2 = userInput[2];
                    var item3 = new List<string>();

                    for (int j = 3; j < userInput.Length; j++)
                    {
                        item3.Add(userInput[j]);
                    }

                    var threeuple = new Threeuple<List<string>, string, List<string>>(item1, item2, item3);

                    Console.WriteLine($"{string.Join(" ", threeuple.Item1)} -> {threeuple.Item2} -> {string.Join(" ", threeuple.Item3)}");
                }
                else if (i == 1)
                {
                    var item1 = userInput[0];
                    var item2 = int.Parse(userInput[1]);
                    var item3 = userInput[2] == "drunk";

                    var threeuple = new Threeuple<string, int, bool>(item1, item2, item3);

                    Console.WriteLine(threeuple.ToString());
                }
                else if (i == 2)
                {
                    var item1 = userInput[0];
                    var item2 = double.Parse(userInput[1]);
                    var item3 = userInput[2];

                    var threeuple = new Threeuple<string, double, string>(item1, item2, item3);

                    Console.WriteLine(threeuple.ToString());
                }
            }
        }
    }
}
