using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> usernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            for (int i = 0; i < usernames.Count; i++)
            {
                string currentUsername = usernames[i];

                if (currentUsername.Length >= 3 && currentUsername.Length <= 16)
                {
                    for (int j = 0; j < currentUsername.Length; j++)
                    {
                        int value = (int)char.Parse(currentUsername[j].ToString());

                        if (value < 48 && value != 45)
                        {
                            usernames.Remove(usernames[i]);
                            i--;
                            break;
                        }
                        else if (value < 65 && value > 57)
                        {
                            usernames.Remove(usernames[i]);
                            i--;
                            break;
                        }
                        else if (value < 97 && value > 90 && value != 95)
                        {
                            usernames.Remove(usernames[i]);
                            i--;
                            break;
                        }
                        else if (value > 122)
                        {
                            usernames.Remove(usernames[i]);
                            i--;
                            break;
                        }
                    }
                }
                else
                {
                    usernames.Remove(usernames[i]);
                    i--;
                }
            }

            foreach (var item in usernames)
            {
                Console.WriteLine(item);
            }
        }
    }
}
