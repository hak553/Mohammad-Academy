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
            Console.WriteLine("1-raining");
            Console.WriteLine("2-sunny");
            Console.WriteLine("3-normal")
            Console.WriteLine("|===================");
            int weather = int.Parse(Console.ReadLine());

            if (weather == 1)
            {
                Console.WriteLine("You need to wear winter clothes.");
            }
            else if (weather == 2)
            {
                Console.WriteLine("You need to wear sunny clothes.");
            }
            else if (weather == 3)
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
