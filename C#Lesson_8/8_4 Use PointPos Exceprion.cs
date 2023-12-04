using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Для класса PointPos - пусть точка должна иметь только положительные координаты

 Реализовать собственный класс исключения.
 */

namespace _8_4_MyException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PointPos point;
            try
            {
                point = new PointPos(-55, -3);
                Console.WriteLine($"{point.X}, {point.Y}");
                //point.X = -10;
                //point.Y = -10;
            }
            catch (PointException exp)
            {
                Console.WriteLine(exp.Message);
                Console.WriteLine("Дата и время: " + exp.DateException);

                Console.WriteLine($"Состояние данных: {exp.XErr}, {exp.YErr}");
            }
           

            Console.ReadLine();
        }
    }
}


/*
 Существуют три способа создания специального
исключения:

1. Конструктор не передает данные базовому классу

2. Конструктор передает данные базовому классу

3. Третий способ заключается в реализации рекомендаций .Net Framework по созданию специального класса
исключения, которые заключаются в следующем:

    - наследоваться от ApplicationException;
    - сопровождаться атрибутом [System.Serializable];
    - иметь конструктор по умолчанию;
    - иметь конструктор, который устанавливает значение унаследованного свойства Message;
    - иметь конструктор для обработки "внутренних исключений";
    - иметь конструктор для обработки сериализации типа.

Exeption + Tab 2 раза


Если планируется создать действительно заслуживающий 
внимания специальный класс исключения, 
необходимо позаботиться о том, 
чтобы он соответствовал наилучшим рекомендациям .NET. 

*/