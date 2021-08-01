using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine()); // чете дължината на полето.
            int[] LadyBugsField = new int[fieldSize]; // създава полето.

            int[] initialIndexes = Console.ReadLine() // прочита индексите, на които има калинка като масив от числа.
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < initialIndexes.Length; i++) // извърта елементите с началните индекси.
            {
                int index = initialIndexes[i]; // взема индекса.
                if (index >= 0 && index < LadyBugsField.Length) // проверява дали индекса не е извън рамките на полето.
                {
                    LadyBugsField[index] = 1; // слага калинка ако индекса е в рамките на полето.
                }
            }

            bool isTrue = true;

            while (isTrue)
            {

                string[] command = ReadCommand(); // прочита командата.                

                if (command[0] == "end")
                {
                    Console.WriteLine(string.Join(" ", LadyBugsField)); // ако има команда "end" печата резултата и прекъсва цикъла.
                    isTrue = false;
                    break;
                }
                else
                {
                    // вземаме индекса на калинката, която отлита и дължината на полета.
                    int ladyBugIndex = int.Parse(command[0]);
                    int flyLength = int.Parse(command[2]);

                    if (ladyBugIndex >= 0 && ladyBugIndex < LadyBugsField.Length) // проверяваме дали индекса с местоположението на калинката е валиден.
                    {
                        if (command[1] == "left" && LadyBugsField[ladyBugIndex] != 0) // ако посоката е "left" и на индекса има калинка - въртим обратен цикъл със стъпка дължината на полета.
                        {                            
                            LadyBugsField[ladyBugIndex] = 0;
                            ladyBugIndex -= flyLength;
                            while (ladyBugIndex >= 0)
                            {
                                if (LadyBugsField[ladyBugIndex] == 0)
                                {
                                    LadyBugsField[ladyBugIndex] = 1;
                                    break;
                                }
                                else
                                {
                                    ladyBugIndex -= flyLength;
                                }
                            }
                            //for (int i = ladyBugIndex; i >= 0; i -= flyLength)
                            //{
                            //    if (LadyBugsField[i] == 0) // проверяваме ако няма калинка на следващия индекс - летящата каца и прекъсва цикъла.
                            //    {
                            //        LadyBugsField[i] = 1;
                            //        break;
                            //    }
                            //}
                            //LadyBugsField[ladyBugIndex] = 0; // премахваме калинката от първоначалния й индекс, след като е кацнала.
                        }
                        else if (command[1] == "right" && LadyBugsField[ladyBugIndex] != 0) // ако посоката е "right" и на индекса има калинка - въртим цикъл със стъпка дължината на полета.
                        {
                            LadyBugsField[ladyBugIndex] = 0;
                            ladyBugIndex += flyLength;
                            while (ladyBugIndex < LadyBugsField.Length)
                            {
                                if (LadyBugsField[ladyBugIndex] == 0)
                                {
                                    LadyBugsField[ladyBugIndex] = 1;
                                    break;
                                }
                                else
                                {
                                    ladyBugIndex += flyLength;
                                }
                            }
                            //for (int i = ladyBugIndex; i < LadyBugsField.Length; i += flyLength)
                            //{
                            //    if (LadyBugsField[i] == 0) // проверяваме ако няма калинка на следващия индекс - летящата каца и прекъсва цикъла.
                            //    {
                            //        LadyBugsField[i] = 1;
                            //        break;
                            //    }
                            //}
                            //LadyBugsField[ladyBugIndex] = 0; // премахваме калинката от първоначалния й индекс, след като е кацнала.
                        }
                    }
                }
            }
        }

        private static string[] ReadCommand() // Метод, който чете командата като string[].
        {
            return Console.ReadLine()
                .ToLower()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
        }
    }
}