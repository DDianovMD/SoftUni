using System;
using System.Collections.Generic;

namespace BorderControl
{
    public class Program
    {
        static void Main()
        {
            // BorderControl problem logic

            // List<IIdentifiable> society = new List<IIdentifiable>();

            // while (true)
            // {
            //     string[] userInput = Console.ReadLine().Split(" ");

            //     if (userInput[0] == "End")
            //     {
            //         break;
            //     }

            //     if (userInput.Length == 3)
            //     {
            //         IIdentifiable citizen = new Citizen(userInput[0], int.Parse(userInput[1]), userInput[2]);
            //         society.Add(citizen);
            //     }
            //     else if (userInput.Length == 2)
            //     {
            //         IIdentifiable robot = new Robot(userInput[0], userInput[1]);
            //         society.Add(robot);
            //     }
            // }

            // string fakeIDending = Console.ReadLine();

            // for (int i = 0; i < society.Count; i++)
            // {
            //     if (society[i].ID.Substring(society[i].ID.Length - fakeIDending.Length, fakeIDending.Length) == fakeIDending)
            //     {
            //         Console.WriteLine(society[i].ID);
            //         society.RemoveAt(i);
            //         i--;
            //     }
            // }

            //  Birthday Celebrations problem logic

            //  List<IBirthable> birthableCreatures = new List<IBirthable>();
            //  List<IIdentifiable> society = new List<IIdentifiable>();
            //  
            //  while (true)
            //  {
            //      string[] userInput = Console.ReadLine().Split(" ");
            //  
            //      if (userInput[0] == "End")
            //      {
            //          break;
            //      }
            //  
            //      if (userInput[0] == "Citizen")
            //      {
            //          IBirthable citizen = new Citizen(userInput[1], int.Parse(userInput[2]), userInput[3], userInput[4]);
            //          birthableCreatures.Add(citizen);
            //      }
            //      else if (userInput[0] == "Robot")
            //      {
            //          // No need to instance it for problem logic :)
            //          IIdentifiable robot = new Robot(userInput[1], userInput[2]);
            //          society.Add(robot);
            //      }
            //      else if (userInput[0] == "Pet")
            //      {
            //          IBirthable pet = new Pet(userInput[1], userInput[2]);
            //          birthableCreatures.Add(pet);
            //      }
            //  }
            //  
            //  string year = Console.ReadLine();
            //  
            //  foreach (var creature in birthableCreatures)
            //  {
            //      if (creature.Birthdate.Substring(creature.Birthdate.Length - year.Length, year.Length) == year)
            //      {
            //          Console.WriteLine(creature.Birthdate);
            //      }
            //  }

            // Food Shortage problem logic

            int numberOfPeople = int.Parse(Console.ReadLine());

            List<Citizen> citizens = new List<Citizen>();
            List<Rebel> rebels = new List<Rebel>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] userInput = Console.ReadLine().Split(" ");

                if (userInput.Length == 4)
                {
                    Citizen citizen = new Citizen(userInput[0], int.Parse(userInput[1]), userInput[2], userInput[3]);
                    citizens.Add(citizen);
                }
                else if (userInput.Length == 3)
                {
                    Rebel rebel = new Rebel(userInput[0], int.Parse(userInput[1]), userInput[2]);
                    rebels.Add(rebel);
                }
            }            

            while (true)
            {
                string buyerName = Console.ReadLine();

                if (buyerName == "End")
                {
                    break;
                }

                foreach (var citizen in citizens)
                {
                    if (citizen.Name == buyerName)
                    {
                        citizen.BuyFood();
                    }
                }

                foreach (var rebel in rebels)
                {
                    if (rebel.Name == buyerName)
                    {
                        rebel.BuyFood();
                    }
                }
            }

            int totalAmountOfFoodBought = 0;

            foreach (var citizen in citizens)
            {
                totalAmountOfFoodBought += citizen.Food;
            }

            foreach (var rebel in rebels)
            {
                totalAmountOfFoodBought += rebel.Food;
            }

            Console.WriteLine(totalAmountOfFoodBought);
        }
    }
}
