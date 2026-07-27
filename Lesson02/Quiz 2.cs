using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            التحدي الثاني اصنع برنامج يطلب من المستخدم 
            ماذا يريد ان يشرب هل شاي او قهوة او عصير 1
            2 وطلب من المستخدم ماذا يفضل الحجم هل كبير او وسط او صغير
            وبعد هذه المعلومات يطبع النتيجة
            */
            Console.WriteLine("<====|Quiz 2|====>");

            Console.WriteLine("<====|Application|====>");
            Console.WriteLine("|----------------------------------------------------------------------------------------------");
            Console.WriteLine("Enter What you need Drink?");
            Console.WriteLine("Coffe or tea or juice");
            string drink = Console.ReadLine();
            Console.WriteLine("|----------------------------------------------------------------------------------------------");
            Console.WriteLine("What Size do you prefer ?");
            Console.WriteLine("Small or medium or Large");
            string size = Console.ReadLine();

            Console.WriteLine("<====|OutPut|====>");
            Console.WriteLine($"the {drink} is being prepared");
            Console.WriteLine($"And it's size {size}");

        }
    }
}
