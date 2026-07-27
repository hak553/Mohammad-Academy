using System;

namespace course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<====|Quiz 1|====>");
            Console.WriteLine("What your name:");
            string name = Console.ReadLine();
            Console.WriteLine("What your age :");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"your name is {name} , your age is {age}");

        }
    }
}
