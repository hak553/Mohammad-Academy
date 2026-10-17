using System;

namespace course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///*
            // |----------------Example
            //    Raining -> You need to wear winter clothes.
            //    Sunny   -> You need to wear sunny clothes.
            //    normal  -> You need to wear any clothes.

            // */
            Console.WriteLine("Enter What is Weather Now?");
            Console.WriteLine("raining , sunny , normal");
            Console.WriteLine("|===================");
            string weather = Console.ReadLine();

            if (weather == "raining")
            {
                Console.WriteLine("You need to wear winter clothes.");
            }
            else if (weather == "sunny")
            {
                Console.WriteLine("You need to wear sunny clothes.");
            }
            else if (weather == "normal")
            {
                Console.WriteLine("You need to wear sunny clothes.");
            }
            else
            {
                Console.WriteLine("Error : the input is Wrong");
            } 
        }
    }
}
