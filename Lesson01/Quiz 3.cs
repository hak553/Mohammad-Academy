using System;

namespace course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====Quiz 3====");
            string nameApp = "PC";

            Console.WriteLine($"====={nameApp}=====");
            string processor = "AMD";
            string motherBoard = "ASUS";
            string graphicCard = "RTX 2060 ";
            string ssd = "1TB";

            Console.WriteLine($"My Processor is {processor}");
            Console.WriteLine($"My MotherBoard is {motherBoard}");
            Console.WriteLine($"My GraphicCard is {graphicCard}");
            Console.WriteLine($"My SSD is {ssd}");

        }
    }
}
