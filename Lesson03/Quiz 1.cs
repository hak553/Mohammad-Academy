using System;

namespace course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///* Challange 1  
            // اصنع برنامج
            // يطلب من المستخدم رقمين وبعدها يعمل على هذه الارقام
            // كل العمليات الرياضية
            // + , - , * , / , %
            // وبعدها يقوم بطباعة الناتج 
            // Addition : Result
            // Subtraction : Result
            // Multiplication : Result
            // Division : Result
            // Modulo : Result
            // */

            //كل برنامج نحتاج المتغيرات وندرجلها قيمة
            Console.WriteLine("Two Value :");
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());

            Console.WriteLine("|--------------------------------");
            // Addition
            int add = x1 + x2;
            Console.WriteLine($"Addition : {add}");
            // Subtraction
            int sub = x1 - x2;
            Console.WriteLine($"Subtraction : {sub}");
            // Multiplication
            int mult = x1 * x2;
            Console.WriteLine($"Multiplication : {mult}");
            // Division
            double div = (double)x1 / x2;
            Console.WriteLine($"Division : {div}");

        }
    }
}
