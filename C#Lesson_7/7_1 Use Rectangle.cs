using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Описать класс ПРЯМОУГОЛЬНИК

Характеристики: ширина, высота

Добавить вычислемые свойства для расчета Площади и Объема.
 */

namespace _7_1_Классы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect ;
            try
            {
                rect = new Rectangle(10,5);
                

                //rect.Width = 20;

                //rect.Height = 20;

                Console.WriteLine(rect.Height + " " + rect.Width);
                Console.WriteLine(rect);
                Console.WriteLine($"Периметр: {rect.Perimetr}");
                Console.WriteLine($"Площадь: {rect.Square}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("\nMessage: {0}", ex.ToString());
                Console.WriteLine("\nMessage: {0}", ex.Message);
                Console.WriteLine("\nSource {0}", ex.Source);
                Console.WriteLine("\nStackTrace {0}", ex.StackTrace);
                Console.WriteLine("\nTargetSite {0}", ex.TargetSite);
            }

            Rectangle rectangle = null;
            try
            {
                rect = new Rectangle(rectangle);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Rectangle rect2 = new Rectangle{
               Height =15,
               Width = 5,
            };
            Console.WriteLine(rect2);
           
            Rectangle rect3 = new Rectangle(rect2);
            rect2.Height = 555;

            Console.WriteLine(rect3);


            Console.ReadLine();
        }
    }
}
