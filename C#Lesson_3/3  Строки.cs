using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Массивы_Строки
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ILDASM - MS Intermediate Language Disassembler

            string a = "Hello, World!";

            Console.WriteLine(a[0]);

            //a[0] = '!';
            a += '!';
            Console.WriteLine(a);
            a = "TEST";
            Console.WriteLine(a);


            StringBuilder sb = new StringBuilder("privet", 60);
            sb.Append("!");
            sb[0] = 'P';
            Console.WriteLine(sb  + "  " + sb.Capacity);

            // Конструторы:
            string line = new string('*', 20);
            Console.WriteLine(line); 

            char[] math_op = {'+', '-','*','/','%' };
            string operations = new string(math_op);
            Console.WriteLine(operations + " "+ operations.Length);

            operations = new string(math_op, 2,3);// со индекса 2 взять 3 значения
            Console.WriteLine(operations + " " + operations.Length);

            //string.com

            Console.ReadLine();
        }

    }
}
