using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lesson_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            int[] mas = null;
            mas = new int[size];
            int[] ar1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] ar2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] ar3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] fruites = { "банан", "апельсин", "слива", "груша" };

            Console.WriteLine(ar1.GetType());
            Console.WriteLine(fruites.GetType());
            Console.WriteLine("Количество элементов" + ar1.Length);
            Console.WriteLine("Количество элементов" + ar2.Length);
            Console.WriteLine("объем памяти" + sizeof(int) * ar2.Length);

            ar1[2] = 100;
            for (int i = 0; i < ar1.Length; i++)
            {
                //Console.WriteLine(ar1[i]+" ");
                //Console.WriteLine("{0} ",ar1[i]);
                //Console.WriteLine("{0} ",ar1[i]);
                Console.WriteLine($"{ar1[i]} ");// интерполированная строка
            }
            Console.WriteLine();
            foreach (var i in ar2)
            {
                //i *= 2;
                Console.WriteLine($"{i}, ");

            }

            Console.WriteLine();
            for (int i = 0; i < ar1.Length; i++)
            {
                Console.WriteLine($"ar1[ar1.Length - i -1] ");
            }

            int[] a = { 12, 5, 6, 9, 7 };
            int[] b = { 1, 3, 9, 8, 7 };

            b = a;
            a[1] = 500;
            foreach (int i in b)
            {
                Console.WriteLine(i + " ");
            }

            int[] copy = new int[a.Length];
            for (int i = 0; i < copy.Length; i++)
            {
                copy[i] = a[i];
            }
            Console.WriteLine();
            a[0] = 1000;//не влияет на значение в массиве copy
            Console.WriteLine("Копия массива");
            foreach (int i in copy)
            {
                Console.WriteLine(i + " "); 
            }
            


            Console.ReadLine();

        }
    }
}
