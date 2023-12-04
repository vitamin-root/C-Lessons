using System;

using _8_1_Методы_расширения; // для Point

using static System.Math;

namespace MyExtensionMethods
{
    /*internal*/public static class PointExtension
    {
        // класс Point должен быть с таким же уровнем доступа как стат. класс(у нас public)
        public static double Distance(this Point p1, Point p2)// у класса меняем на public
        {
            //Console.WriteLine("Расстояние: ");
            //return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
            return System.Math.Sqrt(Pow(p1.X - p2.X, 2) + Pow(p1.Y - p2.Y, 2)); //using static System.Math;
        }
    }
}


//-----------------------------------------------------------------------------
// Расширяющий метод(должен быть объявлен в статическом классе)
//using static System.Math;
