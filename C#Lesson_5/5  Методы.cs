using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;


namespace _5_1_Методы
{
    struct Point
    {
        public double X;
        public double Y;
        public decimal a;
        public decimal b;
        public decimal c;
        public decimal d;
    }
    internal class Program
    {
        static public void Message() => Console.WriteLine("Hello, World!");
        static public int Sum(int a, int b) =>  a + b;

        static public void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
        static public void SetPoint(ref Point p)
        {
            p.X = 10;
            p.Y = 5;
        }
        static void SetArray(int []m)
        {
            m[0] = 200;
        }
        static ref int TestRef(int[]m)
        {
            return ref m[0];
        }
      
        static void MyResize(ref int []arr, int newSize)
        {
            int []tmp=new int[newSize];
            if(newSize > arr.Length)
            {
                for(int i=0; i<arr.Length;i++)
                {
                    tmp[i]=arr[i];
                }
            }
            else
            {
                for (int i = 0; i < newSize; i++)
                {
                    tmp[i] = arr[i];
                }
            }
            arr = tmp;
        }
        static void Arifmetic(int a, int b, out int summa, out int mult)
        {
            summa = a + b;
            mult = a * b;
        }
        static void SquarePerimetr(int height, int width, out int sq,out int per )
        {
            sq = height * width;
            per = 2*(width + height);
        }
        static void SetRectangle( int height = 2,  int width = 1)
        {
            Console.WriteLine("Высота: {0}", height);
            Console.WriteLine("Ширина: {0}", width);
        }

        static void TestIN(in int a, in StringBuilder sb)
        {
            //a = 25; // readonly
            Console.WriteLine($"{a}");

            sb.Append("!"); // значние менять можно
           // sb = new StringBuilder();// ссылку менять нельзя
        }

        static void TestPoint(Point p) { }
        static void TestPointIN(in Point p) { }

        static int Sum(params int[]parameters)
        {
            int sum = 0;
            //for(int i = 0;i < parameters.Length;i++)
            //{
            //    sum+=parameters[i];
            //}
            foreach (int i in parameters)
            {
                //i = 2;
                sum += i;
            }
            return sum;
        }

        static void TestParams(params object[] parameters)
        {
            foreach (object param in parameters)
            {
                Console.WriteLine("Тип {0}  Значение {1}", param.GetType(), param);
            }
        }

        static void Compare(int[] numbers1, int[] numbers2)
        {
            int Perfect1 = CountPerfect(numbers1);
            int Perfect2 = CountPerfect(numbers2);

            if (Perfect2 > Perfect1)
                Console.WriteLine($"Во втором массиве больше совершенных числел: " +
                    $"{Perfect2} > {Perfect1} ");
            else if (Perfect2 < Perfect1)
                Console.WriteLine($"Во втором массиве меньше совершенных числел: " +
                    $"{Perfect2} < {Perfect1} ");
            else
                Console.WriteLine($"Количество совершенных числе в массивах равны: " +
                    $"{Perfect2} = {Perfect1}");
            // Локальные функции
            int CountPerfect(int[] numbers)
            {
                int k = 0;
                foreach (int number in numbers)
                    if (IsPerfectNumber(number))
                        k++;
                return k;
            }
            bool IsPerfectNumber(int n)
            {
                int sum = 0;
                for (int i = 1; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        sum += i;
                    }
                }
                if (n == sum && n != 0)
                {
                    return true;
                }
                return false;
            }
        }
        static void Main(string[] args)
        {

        

            /*
             Локальные функции представляют функции, 
            определенные внутри других методов. 

            Локальная функция содержит действия, 
            которые применяются только в рамках ее метода.

            При этом неважно, определена локальная функция до или после использования.

            Но вне ее метода локальная функция не может использоваться.


            Локальные функции могут быть статическими. 
            Такие функции определяются с помощью ключевого слова static. 
            Их особенностью является то, что они 
            не могут обращаться к переменным окружения, 
            то есть метода, в котором статическая функция определена.
                 */

            //6, 28, 496, 8128, 33550336
            int[] numbers1 = { 496, 122, 312, 28, 6 };
            int[] numbers2 = { 3, 432, 5, 6, 7, 8128 };
            
            MyDll.ShowColorArr(numbers1);

            Compare(numbers1, numbers2);

            
#if false

            //-------------------------------------------
            // Пример - передача произвольного количества параметров разного типа
            // На практике - это крайне редкая ситуация

            //object - базовый класс для всех типов данных
            // int - value-type  значимый тип

            // В результате процесса упаковки  значимый тип размещается в куче,
            // соответственно потом при обращении к переменной 'a' будет операция
            // распаковки
            // Это чуть позже, но такие операции затратны и лучше их избегать

            TestParams("Hello!!!", 12.652, '+', true);

            int a = 10;
            object obj = a;
            Console.WriteLine(obj);

#endif

#if false

            //----------------------------------------------
            // Ключевое слово params
            // - params всегда последний в списке параметров
            // - должен указывать на одномерный массив любого типа
            // - в одном методе может быть только один модификатор params

            int summa = Sum();
            Console.WriteLine(summa);

            summa = Sum(2, 3, 6, 10, 6);
            Console.WriteLine(summa);

            int[] m = new int[] { 1, 3, 9 };
            summa = Sum(m);
            Console.WriteLine(summa);

#endif

#if false

            //----------------------------------------------
            // Пример: Проверка скорости выполнения программы
            // using System.Diagnostics;

            Point p = new Point();

            Stopwatch sw = Stopwatch.StartNew();
            for(int i = 0; i < int.MaxValue;i++)
            {
                TestPoint(p);
            }
            sw.Stop();
            Console.WriteLine("TestPoint => "+sw.ElapsedMilliseconds);

            sw.Restart();
            for (int i = 0; i < int.MaxValue; i++)
            {
                TestPointIN(p);
            }
            sw.Stop();
            Console.WriteLine("TestPointIN => " + sw.ElapsedMilliseconds);

#endif

#if false

            //----------------------------------------------
            // Ключевое слово in, начиная с версии языка 7.2

            // Ключевое слово in позволяет передать параметр по ссылке объект структуры,
            // но изменить внутри метода переменную не можем(по сути readonly)

            // Мотивация использования: экономия памяти при передаче структур!!!
            //(но для объектов ссылочных типов такое ограничение не предусмотрено в самом языке).

            //--------------------------------
            // Задача: Написать функцию, которая принимает размеры прямоугольника
            // и возвращает его площадь и периметр.

            //----------------------------------
            // Параметры по умолчанию - аналогично С++

            // Именованные параметры - в произвольном порядке можно передать параметры, но
            // надо указать имя_параметра: значение  (переменная)

            // Зачем:
            // - добавляет читабельность кода
            // - экономит время для анализа назначения параметров
            SetRectangle();

            SetRectangle(25, 30);

            SetRectangle(width: 5, height: 10);// Именованные параметры 


#endif

#if false

            Console.WriteLine("Введите число:");
            string s = Console.ReadLine();

            bool r = int.TryParse(s, out int number);
            if(r)
            {
                Console.WriteLine($"number : {number}");
            }else
                Console.WriteLine("Неверные данные!");

            //---------------------------------------------------------
            //out

            // ref и out - работают по ссылке
            // при out можем не задавать начальное значение
            // !!!   out - гарантирует, что метод будет присвоено значение !!!
            // В функцию с параметром ref нельзя предать неинициализированную переменную

            int a = 5, b = 3, sm = 0, mlt;
            Arifmetic(a, b, out sm, out mlt);
            Console.WriteLine($"сумма: {sm} умножение: {mlt}");

            // Объявление переменных в момент вызова метода(в параметрах)
            Arifmetic(a, b, out int sm2, out int mlt2);
            Console.WriteLine($"сумма: {sm2} умножение: {mlt2}");


            //---------------------------------------------------------
            // Самостоятельно  : Написать метод MyResize, меняющий размер массива
            int[] m = new int[] { 5, 3, 6 };
            //Array.Resize(ref m, 10);
            MyResize(ref m, 10);
            foreach (int i in m)
            {
                Console.Write($"{i}  ");
            }

#endif

#if false

            // Массив - ссылочный тип
            int[]m=new int[] { 5,3,6};
            SetArray(m);
            Console.WriteLine("m[0] = {0}",m[0]);

            // Ссылочная локальная перменная   -
            // появилось в более поздних версиях языка
            ref int myRef = ref m[0];
            myRef = 500;
            Console.WriteLine("m[0] = {0}", m[0]);

            // Возврат по ссылке
            ref int result = ref TestRef(m);
            result = -200;
            Console.WriteLine("m[0] = {0}", m[0]);//-200


            Point p = new Point();
            Console.WriteLine($"{p.X}  {p.Y}");
            SetPoint(ref p);
            Console.WriteLine($"{p.X}  {p.Y}");
            Console.WriteLine();
            //-------------------------------------------------------
            // Модификаторы параметров, которые передаются методам: ref
            // Написать метод Swap для обмена двух целых

            int a = 5, b = 10;
            Console.WriteLine($"{a}  {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"{a}  {b}");

            //-------------------------------------------------------
            // Короткая запись метода => Однострочный метод
            // Реализация тела метода-выражения
            // Expression-bodied method
            Program.Message();
            Console.WriteLine(Sum(2,6));


#endif


            Console.ReadLine();
        }

    }
}
