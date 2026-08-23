using System;

namespace course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // All Basic Arithmatic Operation[Math]
            /// Simple 1
            // Addition -> +
            Console.WriteLine(5 + 5);
            // Subtraction -> -
            Console.WriteLine(2 - 4);
            // Multiplication -> *
            Console.WriteLine(2 * 3);
            // Division -> /
            Console.WriteLine(3d / 2);
            Console.WriteLine(3 / 2d);
            Console.WriteLine(3d / 2d);
            Console.WriteLine(3 / 2);
            Console.WriteLine(10d / 2d);
            // Modulo -> %
            Console.WriteLine(27 % 6);

            /// Advance 2
            // Addition -> +
            Console.WriteLine($"result: {5 + 5}");
            // Subtraction -> -
            Console.WriteLine($"result: {5 - 5}");
            // Multiplication -> *
            Console.WriteLine($"result: {5 * 5}");
            // Division -> /
            Console.WriteLine($"result: {5 / 5}");
            // Modulo -> %
            Console.WriteLine($"result: {5 % 5}");

            /// Varabile 3
            // Addition -> +
            double sum = 5 + 5;     //Logic
            Console.WriteLine($"Result : {sum}"); // UI
            // Subtraction -> -
            double sub = 5 - 5;     //Logic
            Console.WriteLine($"Result : {sub}"); // UI
            // Multiplication -> *
            double mult = 5 * 5;     //Logic
            Console.WriteLine($"Result : {mult}"); // UI
            // Division -> /
            double div = 3d / 5;     //Logic
            Console.WriteLine($"Result : {div}"); // UI
            // Modulo -> %
            double mod = 5 % 5;     //Logic
            Console.WriteLine($"Result : {mod}"); // UI

        }
    }
}