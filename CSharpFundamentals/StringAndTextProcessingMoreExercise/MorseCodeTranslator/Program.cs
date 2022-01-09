using System;
using System.Collections.Generic;
using System.Linq;

namespace MorseCodeTranslator
{
    class Program
    {
        static void Main()
        {
            List<string> morseCode = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<char> translatedMessage = new List<char>();

            for (int i = 0; i < morseCode.Count; i++)
            {
                switch (morseCode[i])
                {
                    case ".-": translatedMessage.Add('A'); break;
                    case "-...": translatedMessage.Add('B'); break;
                    case "-.-.": translatedMessage.Add('C'); break;
                    case "-..": translatedMessage.Add('D'); break;
                    case ".": translatedMessage.Add('E'); break;
                    case "..-.": translatedMessage.Add('F'); break;
                    case "--.": translatedMessage.Add('G'); break;
                    case "....": translatedMessage.Add('H'); break;
                    case "..": translatedMessage.Add('I'); break;
                    case ".---": translatedMessage.Add('J'); break;
                    case "-.-": translatedMessage.Add('K'); break;
                    case ".-..": translatedMessage.Add('L'); break;
                    case "--": translatedMessage.Add('M'); break;
                    case "-.": translatedMessage.Add('N'); break;
                    case "---": translatedMessage.Add('O'); break;
                    case ".--.": translatedMessage.Add('P'); break;
                    case "--.-": translatedMessage.Add('Q'); break;
                    case ".-.": translatedMessage.Add('R'); break;
                    case "...": translatedMessage.Add('S'); break;
                    case "-": translatedMessage.Add('T'); break;
                    case "..-": translatedMessage.Add('U'); break;
                    case "...-": translatedMessage.Add('V'); break;
                    case ".--": translatedMessage.Add('W'); break;
                    case "-..-": translatedMessage.Add('X'); break;
                    case "-.--": translatedMessage.Add('Y'); break;
                    case "--..": translatedMessage.Add('Z'); break;
                    case "|": translatedMessage.Add(' '); break;
                }
            }

            foreach (var symbol in translatedMessage)
            {
                Console.Write(symbol);
            }
        }
    }
}
