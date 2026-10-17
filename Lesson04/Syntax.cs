using System;

namespace course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condition -> true Or false
            int age = int.Parse(Console.ReadLine());
            //Syntax
            if (age >= 18) // 18,19,20.....
            {
                Console.WriteLine("You can Enter");
            }
            else if (age >= 10) // 10,11...17
            {
                Console.WriteLine("You can't Enter");
            }
            else
            {
                Console.WriteLine("You are Child");
            }
        }
    }
}
