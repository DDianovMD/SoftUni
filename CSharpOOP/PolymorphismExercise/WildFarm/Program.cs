using System;
using System.Collections.Generic;
using System.Linq;
using WildFarm.Animals;
using WildFarm.Foods;

namespace WildFarm
{
    public class Program
    {
        static void Main()
        {
            List<Animal> zoo = new List<Animal>();
            int counter = 0;

            while (true)
            {
                string[] userInput = Console.ReadLine().Split();

                if (userInput[0].ToLower() == "end")
                {
                    break;
                }

                if (counter % 2 == 0)
                {                    
                    switch (userInput[0])
                    {
                        case "Owl":
                            Animal owl = new Owl(userInput[1], double.Parse(userInput[2]), double.Parse(userInput[3]));
                            zoo.Add(owl);
                            break;
                        case "Hen":
                            Animal hen = new Hen(userInput[1], double.Parse(userInput[2]), double.Parse(userInput[3]));
                            zoo.Add(hen);
                            break;
                        case "Mouse":
                            Animal mouse = new Mouse(userInput[1], double.Parse(userInput[2]), userInput[3]);
                            zoo.Add(mouse);
                            break;
                        case "Dog":
                            Animal dog = new Dog(userInput[1], double.Parse(userInput[2]), userInput[3]);
                            zoo.Add(dog);
                            break;
                        case "Cat":
                            Animal cat = new Cat(userInput[1], double.Parse(userInput[2]), userInput[3], userInput[4]);
                            zoo.Add(cat);
                            break;
                        case "Tiger":
                            Animal tiger = new Tiger(userInput[1], double.Parse(userInput[2]), userInput[3], userInput[4]);
                            zoo.Add(tiger);
                            break;
                        default:
                            break;
                    }
                }
                else if (counter % 2 != 0)
                {
                    int lastAnimalIndex = zoo.Count - 1;

                    if (userInput[0] == "Vegetable")
                    {
                        Food vegetable = new Vegetable(int.Parse(userInput[1]));
                        Console.WriteLine(zoo[lastAnimalIndex].AskForFood());
                        zoo[lastAnimalIndex].Eat(vegetable);
                    }
                    else if (userInput[0] == "Fruit")
                    {
                        Food fruit = new Fruit(int.Parse(userInput[1]));
                        Console.WriteLine(zoo[lastAnimalIndex].AskForFood());
                        zoo[lastAnimalIndex].Eat(fruit);
                    }
                    else if (userInput[0] == "Meat")
                    {
                        Food meat = new Meat(int.Parse(userInput[1]));
                        Console.WriteLine(zoo[lastAnimalIndex].AskForFood());
                        zoo[lastAnimalIndex].Eat(meat);
                    }
                    else if (userInput[0] == "Seeds")
                    {
                        Food seeds = new Seeds(int.Parse(userInput[1]));
                        Console.WriteLine(zoo[lastAnimalIndex].AskForFood());
                        zoo[lastAnimalIndex].Eat(seeds);
                    }
                }

                counter++;
            }

            foreach (var animal in zoo)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
