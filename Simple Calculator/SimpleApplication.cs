using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // i use simple code you can write prefetion code
            double[] numbers;
            int countNumber;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" <====|My Calculator|====>");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nEnter the number of numbers you want: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            countNumber = int.Parse(Console.ReadLine());

            numbers = new double[countNumber];
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n|---------------------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t|====Enter The Input====|");

            for (int i = 0; i < numbers.Length;i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"Enter The Number [{i}]: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                numbers[i] = double.Parse(Console.ReadLine());
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n|---------------------------------------------------------------------------------------------------------------------");
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t|====Enter The Operation====|");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"1) Additon -> +");
            Console.WriteLine($"2) Subtraction -> -");
            Console.WriteLine($"3) Multiplication -> *");
            Console.Write("Enter The Number from [1-3] : ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            int operation = int.Parse(Console.ReadLine());
            double op;
            switch(operation)
            {
                case 1:
                    op = 0;
                    for(int i = 0; i< numbers.Length; i++)
                    {
                        op += numbers[i];
                    }
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\n|---------------------------------------------------------------------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\t|====The result of Operation====|");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Result : ");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(op);
                    break;
                case 2:
                    op = 0;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        op = numbers[i] - op;
                    }
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\n|---------------------------------------------------------------------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\t|====The result of Operation====|");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Result : ");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(op);
                    break;
                case 3:
                    op = 1;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        op *= numbers[i];
                    }
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\n|---------------------------------------------------------------------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\t|====The result of Operation====|");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Result : ");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(op);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\n|---------------------------------------------------------------------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error Restart the APP !!!!");break;
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n|---------------------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("<====|End Program|====>\n");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
