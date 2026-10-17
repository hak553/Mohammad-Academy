using System;

namespace course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* |------------Game
             
               Health -> 100 -> You are bro -> 50 100
               Health -> 50  -> You need Hide -> 0 50
               Health -> 0   -> Game Over

             */

            int health = 0;
            if (health > 50)
            {
                Console.WriteLine("You are bro");
            }
            else if (health > 0)
            {
                Console.WriteLine("You need Hide");
            }
            else
            {
                Console.WriteLine("Game Over");
            }
        }
    }
}
