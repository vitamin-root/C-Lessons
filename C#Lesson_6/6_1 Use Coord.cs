using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Описать класс КООРДИНАТА для хранения трех координат дробного типа.

Конструтор, методы доступа.
Вывод данных об объекте.

Посчитать количество созданных объектов.
 */

namespace _6_1_Классы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coord coord = new Coord();
            coord.Show();
            Coord coord2 = new Coord(12.25,-5.0,6.47);
            coord2.Show();
            coord2.SetX(560);
            coord2.Show();

            // Доступ к статическому полю/методу класса ТОЛЬКО через имя класса
            Console.WriteLine("Количество объектов: {0}",Coord.GetCount());
            //Coord.MAX = 100;// менять не можем, т.к. readonly
            Console.WriteLine("MAX : {0}", Coord.MAX);
            Console.WriteLine("MIN : {0}", Coord.MIN);

            // К нестатическому полю readinly досту через экземпляр класса
            Console.WriteLine("Name: {0}", coord.name);
            //Console.WriteLine("Name: {0}", Coord.name);// error

            //Console.WriteLine("Объем памяти: {0}", sizeof(Coord));

            //Coord coord3 = coord2;// копия ссылки!
            //coord3.Show();

            //1. Констуктор копий
            Coord coord1 = new Coord(coord2);
            coord2.SetX(-200);
            coord1.Show();

            //2. метод Copy
            Coord coord3 = coord1.Copy();
            coord1.SetY(1000);
            coord3.Show();

            Console.WriteLine("Количество объектов: {0}", Coord.GetCount());


            //Деконструктор - выполняет декомпозицию объекта
            coord3.Deconstruct(out double rx, out double ry,
                out double rz);
            Console.WriteLine($"{rx:F2}  {ry:F2}  {rz:F2}  ");
            // или
            (double rx2, double ry2, double rz2) = coord3;
            Console.WriteLine($"{rx2:F2}  {ry2:F2}  {rz2:F2}  ");

            Console.ReadLine();
        }
    }
}
