using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int DNALenght = int.Parse(Console.ReadLine());
            int[] bestDNA = new int[DNALenght];

            string command = Console.ReadLine();
            int sampleCounter = 0;

            int currentSubSequenceLength = 0;            
            int currentIndex = 0;
            int index = 0;
            int subSequenceLength = 0;
            int currentSum = 0;

            int bestLength = 0;
            int bestIndex = 0;
            int bestSum = 0;
            int bestSampleCounter = 0;

            while (true)
            {
                if (command.ToUpper() == "CLONE THEM!")
                {
                    Console.WriteLine($"Best DNA sample {bestSampleCounter} with sum: {bestSum}.");
                    for (int i = 0; i < bestDNA.Length; i++)
                    {
                        Console.Write(bestDNA[i] + " ");
                    }
                    break;
                }
                
                int[] array = command.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                sampleCounter += 1;                

                for (int j = 0; j < array.Length; j++) // Calculate subsequence of ones length
                {
                    if (array[j] == 1)
                    {
                        currentSubSequenceLength += 1;

                        if (j == 0)
                        {
                            currentIndex = j;
                        }
                        else
                        {
                            currentIndex = j - (currentSubSequenceLength - 1);
                        }
                    }
                    else
                    {
                        if (currentSubSequenceLength > subSequenceLength)
                        {
                            subSequenceLength = currentSubSequenceLength;
                            index = currentIndex;
                            currentSubSequenceLength = 0;
                        }                                                
                    }                    
                }
                if (currentSubSequenceLength > subSequenceLength)
                {
                    subSequenceLength = currentSubSequenceLength;
                    index = currentIndex;
                    currentSubSequenceLength = 0;
                }
                currentSubSequenceLength = 0;

                //calculate current sum
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 1)
                    {
                        currentSum += 1;
                    }
                }

                //compare probes
                if (subSequenceLength > bestLength)
                {
                    bestLength = subSequenceLength;
                    bestIndex = index;                    
                    bestSum = currentSum;
                    bestSampleCounter = sampleCounter;
                    SaveBestArray(bestDNA, array);                    
                }
                else if (subSequenceLength == bestLength)
                {
                    if (index < bestIndex)
                    {
                        bestLength = subSequenceLength;
                        bestIndex = index;
                        bestSum = currentSum;
                        bestSampleCounter = sampleCounter;
                        SaveBestArray(bestDNA, array);                        
                    }
                    else if (index == bestIndex)
                    {
                        if (currentSum > bestSum)
                        {
                            bestLength = subSequenceLength;
                            bestIndex = index;
                            bestSum = currentSum;
                            bestSampleCounter = sampleCounter;
                            SaveBestArray(bestDNA, array);                            
                        }
                        if (currentSum == bestSum && currentSum == 0)
                        {
                            bestSampleCounter = 1;
                        }
                    }
                }
                currentSum = 0;
                subSequenceLength = 0;
                command = Console.ReadLine();
            }
        }

        private static void SaveBestArray(int[] bestDNA, int[] array)
        {
            for (int i = 0; i < bestDNA.Length; i++)
            {
                bestDNA[i] = array[i];
            }
        }
    }
}