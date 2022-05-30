using System;
using System.Collections.Generic;

namespace BorderControl
{
    public class Program
    {
        static void Main()
        {
            List<IIdentifiable> society = new List<IIdentifiable>();

            while (true)
            {
                string[] userInput = Console.ReadLine().Split(" ");

                if (userInput[0] == "End")
                {
                    break;
                }

                if (userInput.Length == 3)
                {
                    IIdentifiable citizen = new Citizen(userInput[0], int.Parse(userInput[1]), userInput[2]);
                    society.Add(citizen);
                }
                else if (userInput.Length == 2)
                {
                    IIdentifiable robot = new Robot(userInput[0], userInput[1]);
                    society.Add(robot);
                }
            }

            string fakeIDending = Console.ReadLine();

            for (int i = 0; i < society.Count; i++)
            {
                if (society[i].ID.Substring(society[i].ID.Length - fakeIDending.Length, fakeIDending.Length) == fakeIDending)
                {
                    Console.WriteLine(society[i].ID);
                    society.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}
