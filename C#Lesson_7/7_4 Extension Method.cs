using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace _7_4_Extension_Method
{
    public static class MyExtension
    {
        public static void ColorShow<Type>(this Type[]mas,ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            for (int i = 0; i < mas.Length; i++)
            {
                Write($"{mas[i]:F2}  ");
            }
            Console.ResetColor();
            WriteLine();
        }

        public static void ColorShow (this string str)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            str = str?.ToUpper()??"Нет Данных!";
            
            for(int i  =0; i<str.Length;i++)
            {
                Console.Write($"{str[i]} ");
            }
            WriteLine();
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] m = new int[] { 1, 2, 3, 4, 5, };

            m.ColorShow();
            m.ColorShow(ConsoleColor.Blue);

            double[] mas = new double[] { 1.256, 2.36, 3, 4, 5, };
            mas.ColorShow(ConsoleColor.Red);

            string[] mas2 = new string[] { "apple", "banana" };
            mas2.ColorShow(ConsoleColor.Green);

            string a = "Hello";
            a.ColorShow();

            string b = null;
            b.ColorShow();

            ReadLine();
        }
    }
}

/* Методы расширения - extension методы---------------------------

Позволяют добавить новый функционал к уже существующим структурам или классам
и при этом не модифицируя сами классы, структуры

  Мотивация:

- В случае, если нет доступа к классу(он в библиотеке или не ваш)
- Мы можем расширить функционал и при помощи наследования,
  написав новый класс потомок и дописав метод,
  НО если это структура, то она не поддерживает наследование.

  Также у класса может быть модификатор sealed, который не позволяет от него наследоваться
  К тому же реализовывть наследование только для одного метода, это очень затратно и лишнее.

  Правила:

  - Методы расширения должны быть статическими и описаны в статическом классе;

  - параметры могут быть, но первым всегда this тип имя,
   где тип - это тот класс(структура), для которого пишем метод;

  - желательно эти методы помещать в отдельное пространство имен
    (для использования using имя_пространства_имен;)
    получили еще один уровень изоляции наших методов.
*/
