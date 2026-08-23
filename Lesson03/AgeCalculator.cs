using System;

namespace course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is Age?");
            Console.WriteLine("|-------------------------");
            Console.WriteLine("What is Year now ? ");
            int currentYr = int.Parse(Console.ReadLine());
            Console.WriteLine("When are you Born ? ");
            int bornYr = int.Parse(Console.ReadLine());
            Console.WriteLine("|-------------------------");

            Console.WriteLine("Your Age is : " + (currentYr - bornYr));

        }
    }
}
