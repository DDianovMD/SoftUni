using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            double percentages = double.Parse(Console.ReadLine());

            int volumeCM = lenght * width * height;
            double volumeDM = volumeCM * 0.001;
            double percent = percentages * 0.01;
            double waterVolume = volumeDM * (1 - percent);
            Console.WriteLine(waterVolume);
        }
    }
}