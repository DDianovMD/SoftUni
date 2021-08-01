using System;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] lastNumbers = new int[numArray.Length];

            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (command[0].ToUpper() != "END")
            {
                if (command[0].ToUpper() == "EXCHANGE")
                {
                    if (int.Parse(command[1]) > numArray.Length - 1 || int.Parse(command[1]) < 0) 
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numArray = ExchangeArray(numArray, command);
                    }

                }
                else if (command[0].ToUpper() == "MAX")
                {
                    if (command[1].ToUpper() == "EVEN")
                    {
                        int index = MaxEvenIndex(numArray);
                        if (index < numArray.Length + 1) // && numArray.Sum() / numArray.Length != numArray[0] - чупи програмата
                        {
                            Console.WriteLine(index);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                    else if (command[1].ToUpper() == "ODD")
                    {
                        int index = MaxOddIndex(numArray);
                        if (index < numArray.Length + 1) // && numArray.Sum() / numArray.Length != numArray[0] - чупи
                        {
                            Console.WriteLine(index);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                }
                else if (command[0].ToUpper() == "MIN")
                {
                    if (command[1].ToUpper() == "EVEN")
                    {
                        int index = MinEvenIndex(numArray);
                        if (index < numArray.Length + 1) // && numArray.Sum() / numArray.Length != numArray[0] - чупи
                        {
                            Console.WriteLine(index);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                    else if (command[1].ToUpper() == "ODD")
                    {
                        int index = MinOddIndex(numArray);
                        if (index < numArray.Length + 1) // && numArray.Sum() / numArray.Length != numArray[0] - чупи
                        {
                            Console.WriteLine(index);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                }
                else if (command[0].ToUpper() == "FIRST")
                {
                    if (int.Parse(command[1]) < 0 || int.Parse(command[1]) > numArray.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        if (command[2].ToUpper() == "EVEN")
                        {
                            Console.Write("[");
                            FirstEvenPrint(numArray, command[1]);
                            Console.WriteLine("]");
                        }
                        else if (command[2].ToUpper() == "ODD")
                        {
                            Console.Write("[");
                            FirstOddPrint(numArray, command[1]);
                            Console.WriteLine("]");
                        }
                    }
                }
                else if (command[0].ToUpper() == "LAST")
                {
                    if (int.Parse(command[1]) < 0 || int.Parse(command[1]) > numArray.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        if (command[2].ToUpper() == "EVEN")
                        {
                            Console.Write("[");
                            LastEvenPrint(numArray, lastNumbers, command[1]);
                            Console.WriteLine("]");
                        }
                        else if (command[2].ToUpper() == "ODD")
                        {
                            Console.Write("[");
                            LastOddPrint(numArray, lastNumbers, command[1]);
                            Console.WriteLine("]");
                        }
                    }
                }


                command = Console.ReadLine()
                          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                          .ToArray();
            }

            Console.Write("[");
            Console.Write(string.Join(", ", numArray));
            Console.WriteLine("]");
        }

        public static void LastOddPrint(int[] numArray, int[] lastNumbers, string command)
        {
            int numbersCount = 0;
            int index = 0;
            for (int i = numArray.Length - 1; i >= 0; i--) // save last numbers in new array
            {
                if (numArray[i] % 2 != 0 && numArray[i] != 0)
                {
                    numbersCount++;
                    if (numbersCount < int.Parse(command))
                    {
                        lastNumbers[index] = numArray[i];
                        index++;
                    }
                    else if (numbersCount == int.Parse(command))
                    {
                        lastNumbers[index] = numArray[i];
                        break;
                    }
                }
            }

            for (int i = lastNumbers.Length - 1; i >= 0; i--)
            {
                if (lastNumbers[i] != 0 && i != 0)
                {
                    Console.Write($"{lastNumbers[i]}, ");
                }
                else if (lastNumbers[i] != 0 && i == 0)
                {
                    Console.Write($"{lastNumbers[i]}");
                }
            }

            for (int i = 0; i < lastNumbers.Length; i++)
            {
                lastNumbers[i] = 0;
            }
        }

        public static void LastEvenPrint(int[] numArray, int[] lastNumbers, string command)
        {
            int numbersCount = 0;
            int index = 0;
            for (int i = numArray.Length - 1; i >= 0; i--) // save last numbers in new array
            {
                if (numArray[i] % 2 == 0 && numArray[i] != 0)
                {
                    numbersCount++;
                    if (numbersCount < int.Parse(command))
                    {
                        lastNumbers[index] = numArray[i];
                        index++;
                    }
                    else if (numbersCount == int.Parse(command))
                    {
                        lastNumbers[index] = numArray[i];
                        break;
                    }
                }
            }

            for (int i = lastNumbers.Length - 1; i >= 0; i--)
            {
                if (lastNumbers[i] != 0 && i != 0)
                {
                    Console.Write($"{lastNumbers[i]}, ");
                }
                else if (lastNumbers[i] != 0 && i == 0)
                {
                    Console.Write($"{lastNumbers[i]}");
                }
            }

            for (int i = 0; i < lastNumbers.Length; i++)
            {
                lastNumbers[i] = 0;
            }
        }

        public static void FirstOddPrint(int[] numArray, string command)
        {
            int printedCount = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] % 2 != 0)
                {
                    printedCount++;
                    if (printedCount < int.Parse(command) && printedCount == 1)
                    {
                        Console.Write($"{numArray[i]}");
                    }
                    else if (printedCount < int.Parse(command) && printedCount != 1)
                    {
                        Console.Write($", {numArray[i]}");

                    }
                    else if (printedCount == int.Parse(command) && printedCount == 1)
                    {
                        Console.Write($"{numArray[i]}");
                        break;
                    }
                    else if (printedCount == int.Parse(command) && printedCount != 1)
                    {
                        Console.Write($", {numArray[i]}");
                        break;
                    }
                }
            }
        }

        public static void FirstEvenPrint(int[] numArray, string command)
        {
            int printedCount = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] % 2 == 0 && numArray[i] != 0)
                {
                    printedCount++;
                    if (printedCount < int.Parse(command) && printedCount == 1)
                    {
                        Console.Write($"{numArray[i]}");
                    }
                    else if (printedCount < int.Parse(command) && printedCount != 1)
                    {
                        Console.Write($", {numArray[i]}");

                    }
                    else if (printedCount == int.Parse(command) && printedCount == 1)
                    {
                        Console.Write($"{numArray[i]}");
                        break;
                    }
                    else if (printedCount == int.Parse(command) && printedCount != 1)
                    {
                        Console.Write($", {numArray[i]}");
                        break;
                    }
                }
            }
        }

        public static int MinOddIndex(int[] numArray)
        {
            int minNumber = int.MaxValue;
            int maxNumberIndex = 0;
            bool isChanged = false;
            for (int i = 0; i < numArray.Length; i++)
            {

                if (numArray[i] < minNumber)
                {
                    if (numArray[i] % 2 != 0)
                    {
                        minNumber = numArray[i];
                        maxNumberIndex = i;
                        isChanged = true;
                    }
                    else
                    {
                        isChanged = false;
                    }
                }
                else if (numArray[i] == minNumber)
                {
                    isChanged = true;
                    maxNumberIndex = i;
                }
            }
            if (isChanged)
            {
                return maxNumberIndex;
            }
            else
            {
                return numArray.Length + 1;
            }
        }

        public static int MinEvenIndex(int[] numArray)
        {
            int minNumber = int.MaxValue;
            int maxNumberIndex = 0;
            bool isChanged = false;
            for (int i = 0; i < numArray.Length; i++)
            {

                if (numArray[i] < minNumber && numArray[i] != 0)
                {
                    if (numArray[i] % 2 == 0)
                    {
                        minNumber = numArray[i];
                        maxNumberIndex = i;
                        isChanged = true;
                    }

                }
                else if (numArray[i] == minNumber && numArray[i] != 0)
                {
                    isChanged = true;
                    maxNumberIndex = i;
                }
            }
            if (isChanged)
            {
                return maxNumberIndex;
            }
            else
            {
                return numArray.Length + 1;
            }
        }

        public static int MaxOddIndex(int[] numArray)
        {
            int maxNumber = int.MinValue;
            int maxNumberIndex = 0;
            bool isChanged = false;
            for (int i = 0; i < numArray.Length; i++)
            {

                if (numArray[i] > maxNumber)
                {
                    if (numArray[i] % 2 != 0 && numArray[i] != 0)
                    {
                        maxNumber = numArray[i];
                        maxNumberIndex = i;
                        isChanged = true;
                    }                    
                }
                else if (numArray[i] == maxNumber && numArray[i] != 0)
                {
                    isChanged = true;
                    maxNumberIndex = i;
                }
            }
            if (isChanged)
            {
                return maxNumberIndex;
            }
            else
            {
                return numArray.Length + 1;
            }
        }

        public static int MaxEvenIndex(int[] numArray)
        {
            int maxNumber = int.MinValue;
            int maxNumberIndex = 0;
            bool isChanged = false;
            for (int i = 0; i < numArray.Length; i++)
            {

                if (numArray[i] > maxNumber)
                {
                    if (numArray[i] % 2 == 0 && numArray[i] != 0)
                    {
                        maxNumber = numArray[i];
                        maxNumberIndex = i;
                        isChanged = true;
                    }                    
                }
                else if (numArray[i] == maxNumber && numArray[i] != 0)
                {
                    isChanged = true;
                    maxNumberIndex = i;
                }
            }
            if (isChanged)
            {
                return maxNumberIndex;
            }
            else
            {
                return numArray.Length + 1;
            }
        }

        public static int[] ExchangeArray(int[] numArray, string[] command)
        {
            if (int.Parse(command[1]) < 0 || int.Parse(command[1]) > numArray.Length - 1)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                int[] firstHalf = new int[int.Parse(command[1]) + 1];
                int[] secondHalf = new int[numArray.Length - firstHalf.Length];

                for (int i = 0; i < firstHalf.Length; i++)
                {
                    firstHalf[i] = numArray[i];
                }

                for (int j = 0; j < (numArray.Length - firstHalf.Length); j++)
                {
                    secondHalf[j] = numArray[firstHalf.Length + j];
                }

                for (int i = 0; i < numArray.Length; i++)
                {
                    if (i < secondHalf.Length)
                    {
                        numArray[i] = secondHalf[i];
                    }
                    else
                    {
                        numArray[i] = firstHalf[i - secondHalf.Length];
                    }
                }
            }
            return numArray;
        }
    }
}
