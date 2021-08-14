using System;
using System.Collections.Generic;

namespace EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = int.Parse(Console.ReadLine());
            string[] names = new string[arrayLength];
            int[] sortedNumbers = new int[names.Length];
            // List<int> encryptedNames = new List<int>(names.Length);

            int encryptedNumber = 0;
            int savedSmallerNumber;
            string currentName;                                 

            for (int i = 0; i < names.Length; i++) // add names in the array
            {
                names[i] = Console.ReadLine();
            }

            for (int i = 0; i < names.Length; i++) // calculate each name's encrypted number by given formula
            {
                currentName = names[i];
                for (int j = 0; j < currentName.Length; j++)
                {
                    if (currentName[j] == 'a' || currentName[j] == 'e' || currentName[j] == 'i' || currentName[j] == 'o' || currentName[j] == 'u')
                    {
                        encryptedNumber += (int)currentName[j] * currentName.Length;
                    }
                    else
                    {
                        encryptedNumber += (int)currentName[j] / currentName.Length;
                    }
                }
                // encryptedNames.Add(encryptedNumber); // adding number to list array
                sortedNumbers[i] = encryptedNumber; // adding number to array
                encryptedNumber = 0;
            }

            // encryptedNames.Sort();
            // for (int i = 0; i < encryptedNames.Count; i++)
            // {
            //     Console.WriteLine(encryptedNames[i]);
            // }

            for (int i = 0; i < sortedNumbers.Length; i++) // sorting numbers in ascending order
            {
                for (int j = i + 1; j < sortedNumbers.Length; j++)
                {
                    if (sortedNumbers[i] > sortedNumbers[j])
                    {
                        savedSmallerNumber = sortedNumbers[j];
                        sortedNumbers[j] = sortedNumbers[i];
                        sortedNumbers[i] = savedSmallerNumber;
                    }
                }
            }

            for (int i = 0; i < sortedNumbers.Length; i++) // print result
            {
                Console.WriteLine(sortedNumbers[i]);
            }
                       
        }
    }
}
