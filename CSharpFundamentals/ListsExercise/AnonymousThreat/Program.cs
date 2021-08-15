using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> userInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string[] command = ReceiveCommand();

            string temporaryString = string.Empty; // used to form whole parts

            while (command[0] != "3:1") // looping while we receive command "3:1" which is the secret code for ending the cycle
            {
                // code for command "merge"

                if (command[0] == "merge")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    if (endIndex > userInput.Count)
                    {
                        endIndex = userInput.Count;
                    }

                    if (startIndex < userInput.Count)
                    {
                        for (int i = startIndex; i < endIndex; i++)
                        {                            
                                temporaryString += userInput[i];                            
                        }

                        userInput.Insert(startIndex, temporaryString);

                        for (int i = 0; i < endIndex - startIndex; i++)
                        {
                            userInput.RemoveAt(startIndex + 1);
                        }

                        temporaryString = string.Empty;
                    }

                }

                // code for command "divide"

                else if (command[0] == "divide")
                {
                    int index = int.Parse(command[1]);
                    int partitions = int.Parse(command[2]);
                    string itemNeededToBeSplitted = userInput[index];
                    int separatedPartsCount = 0; // counting how many parts are separated already

                    List<char> charList = new List<char>(userInput[index].Length); // creating list of chars

                    for (int i = 0; i < itemNeededToBeSplitted.Length; i++) // splitting item into single chars
                    {
                        charList.Add(itemNeededToBeSplitted[i]);
                    }


                    List<string> partsList = new List<string>(partitions); // creating list for parts

                    if (charList.Count % partitions == 0) // if all parts are with equal length
                    {                        
                        for (int currentChar = 1; currentChar <= charList.Count; currentChar++) 
                        {
                            if (currentChar % (charList.Count / partitions) == 0) // check if we have all chars to form a whole part
                            {                                
                                for (int j = separatedPartsCount * (charList.Count / partitions); j < currentChar; j++) // grouping needed chars as whole part
                                {
                                    temporaryString += charList[j];
                                }

                                separatedPartsCount += 1;
                                partsList.Add(temporaryString); // adding created part in the list
                                temporaryString = string.Empty; // clearing temporary string used to create whole part
                            }                            
                        }

                        for (int i = 0; i < partsList.Count; i++) // adding each part in the original list
                        {
                            userInput.Insert(index + 1 + i, partsList[i]);
                        }

                        userInput.RemoveAt(index); // removing splitted item from original list
                        partsList.Clear(); // clearing partsList
                    }
                    else if (charList.Count % partitions != 0) // if all parts aren't with equal length
                    {
                        for (int currentChar = 1; currentChar <= charList.Count; currentChar++)
                        {
                            if (currentChar % (charList.Count / partitions) == 0 && currentChar != partitions + charList.Count % partitions) // check if we have all chars to form a whole part && we haven't yet reached the last part which is bigger than others
                            {
                                for (int j = separatedPartsCount * (charList.Count / partitions); j < currentChar; j++) // grouping needed chars as whole part
                                {
                                    temporaryString += charList[j];
                                }

                                separatedPartsCount += 1;
                                partsList.Add(temporaryString); // adding created part in the list
                                temporaryString = string.Empty; // clearing temporary string used to create whole part
                            }
                            else if (currentChar % (charList.Count / partitions) != 0 && currentChar == partitions + charList.Count % partitions) // check if we have all chars to form a whole part && we have reached the last part which is bigger than others
                            {
                                for (int j = separatedPartsCount * partitions; j <= charList.Count - 1; j++) // grouping needed chars as whole part (last part)
                                {
                                    temporaryString += charList[j];
                                }

                                separatedPartsCount += 1;
                                partsList.Add(temporaryString); // adding created part in the list
                                temporaryString = string.Empty; // clearing temporary string used to create whole part
                                break; // breaking the cycle since we have formed the last part already
                            }
                        }

                        for (int i = 0; i < partsList.Count; i++) // adding each part in the original list
                        {
                            userInput.Insert(index + 1 + i, partsList[i]);
                        }

                        userInput.RemoveAt(index); // removing splitted item from original list
                        partsList.Clear(); // clearing partsList
                    }
                }

                command = ReceiveCommand();
            }

            Console.WriteLine(string.Join(" ", userInput));
        }

        public static string[] ReceiveCommand()
        {
            return Console.ReadLine().ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
        }
    }
}
