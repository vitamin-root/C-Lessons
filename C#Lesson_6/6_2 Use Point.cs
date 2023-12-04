using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Описать класс Point (две координаты)
с использованием свойств

Вместо Show переопределить метод ToString()
 */

namespace _6_2_Use_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            Console.WriteLine($"{p.X};{p.Y}");
            p.X = 20;
            p.Y = -5;

            Console.WriteLine($"{p.X};{p.Y}");

            string tmp = $"{p.X};{p.Y}";
            Console.WriteLine(tmp);

            // Инициализация объекта через свойства
            Point p2 = new Point {
                X = -10,
                Y = 95
            };
            Console.WriteLine($"{p2.X};{p2.Y}");

            Console.WriteLine();

            Console.WriteLine(p2);
            Console.WriteLine($"{p2}");

            Point p3 = new Point(p);
            Console.WriteLine(p3);
            
            Console.ReadLine();
        }
    }
}
