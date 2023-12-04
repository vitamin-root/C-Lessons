using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyExtensionMethods;

namespace _8_1_Методы_расширения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Написать для класса Point метод расширения,
             который определяет расстояние между двумя точками.
            */

            //1  using MyExtensionMethods;
            Point c1 = new Point(4, 5);
            Point c2 = new Point(-5, 10);
            double distance = c1.Distance(c2);//using MyExtensionMethods;

            Console.WriteLine($"Расстояние между точками составляет: {distance:F2}");
            Console.WriteLine($"Расстояние между точками {c1} и {c2} составляет: {distance:F2}");


            //2 Вызов с использованием полного пути
            //distance = MyExtensionMethods.PointExtension.Distance(c1, c2);
            distance = MyExtensionMethods.PointExtension.Distance(c1, c2);
            Console.WriteLine($"Расстояние между точками {c1} и {c2} составляет: {distance:F2}");


            Console.ReadLine();
        }
    }
}
