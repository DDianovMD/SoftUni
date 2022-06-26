using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneShop
{
    class Program
    {
        static void Main()
        {
            List<string> phones = Console.ReadLine()
                                         .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                         .ToList();

            while (true)
            {
                string[] command = Console.ReadLine()
                                          .Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "End")
                {
                    break;
                }
                else if (command[0] == "Add")
                {
                    if (phones.Contains(command[1]) == false)
                    {
                        phones.Add(command[1]);
                    }
                }
                else if (command[0] == "Remove")
                {
                    if (phones.Contains(command[1]))
                    {
                        phones.Remove(command[1]);
                    }
                }
                else if (command[0] == "Bonus phone")
                {
                    string oldPhone = command[1].Split(':', StringSplitOptions.RemoveEmptyEntries).ElementAt(0);
                    string newPhone = command[1].Split(':', StringSplitOptions.RemoveEmptyEntries).ElementAt(1);

                    if (phones.Contains(oldPhone))
                    {
                        int oldPhoneIndex = phones.IndexOf(oldPhone);
                        phones.Insert(oldPhoneIndex + 1, newPhone);
                    }
                }
                else if (command[0] == "Last")
                {
                    if (phones.Contains(command[1]))
                    {
                        phones.Add(command[1]);
                        phones.Remove(command[1]);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", phones));
        }
    }
}
