using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 
Описать класс ПРЯМОУГОЛЬНИК

Характеристики: координаты левого верхнего и правого нижнего углов.
Тип координат - класс Point
 */

using _6_2_Use_Point;

namespace _7_2_Use_RectanglePoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Point p = new Point();
            RectanglePoint rectanglePoint = new RectanglePoint();
            Console.WriteLine($"{rectanglePoint.TopLeft.X}");
            Console.WriteLine();

            RectanglePoint rectanglePoint2 = new RectanglePoint(
                new Point(5,-5),new Point(2,9));

            Console.WriteLine($"{rectanglePoint2.TopLeft} " +
                $"{rectanglePoint2.BottomRight}");


            Console.WriteLine();

            RectanglePoint rectanglePoint3 = new RectanglePoint(rectanglePoint2);
            rectanglePoint2.TopLeft.X = 100;

            Console.WriteLine($"{rectanglePoint3.TopLeft} " +
                 $"{rectanglePoint3.BottomRight}");

            Console.WriteLine(rectanglePoint3);

            string s = null;
            //if (s == null)
            //{
            //    //Console.WriteLine("Нет данных");
            //    s = s ?? "Нет данных";
            //    Console.WriteLine(s);
            //}
            //else
            //{
            //    Console.WriteLine("Строка: {0}", s.ToUpper());
            //}

            // ?? - оператор объединения с null
            // ?. - оператор условного null / Null - conditional
            Console.WriteLine("Строка: {0}", s?.ToUpper()??"Нет данных!");

           

            Console.ReadLine();
        }
    }
}
