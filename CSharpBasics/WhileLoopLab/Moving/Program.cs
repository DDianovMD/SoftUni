using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            int volume = width * length * hight;
            int boxVolume = 0;

            string boxes = Console.ReadLine();

            while (boxes != "Done")
            {
                boxVolume += int.Parse(boxes);
                if (boxVolume >= volume)
                {
                    int neededspace = boxVolume - volume;
                    Console.WriteLine($"No more free space! You need {neededspace} Cubic meters more.");
                    break;
                }
                boxes = Console.ReadLine();
            }
            if (boxes == "Done")
            {
                int volumeleft = volume - boxVolume;
                Console.WriteLine($"{volumeleft} Cubic meters left.");
            }
        }
    }
}