using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_Строки
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if false

            // Конструторы:
            string line = new string('*', 20);
            Console.WriteLine(line);

            char[] math_op = { '+', '-', '*', '/', '%' };
            string operations = new string(math_op);
            Console.WriteLine(operations + " " + operations.Length);

            operations = new string(math_op, 2, 3);// с индекса 2 взять 3 значения
            Console.WriteLine(operations + " " + operations.Length);


            
            string a = null;// строка без значения
            //Console.WriteLine(a.Length); //System.NullReferenceException: '

            string b = ""; // Пустая строка
            string c = string.Empty;

            Console.WriteLine(b.Length);
            Console.WriteLine(c.Length);

            Console.WriteLine(string.IsNullOrEmpty(a)); // True
            Console.WriteLine(string.IsNullOrEmpty(b)); //True
            Console.WriteLine(string.IsNullOrEmpty(c)); //True
            Console.WriteLine(string.IsNullOrEmpty("Hello")); //False

            if(a != null)
            {
                Console.WriteLine(a + "  "+a.Length);
            }
            else
            {
                Console.WriteLine("Нет данных!");
            }

            // ?? - оператор объединения с null
            string res = a ?? "Нет данных!";
            Console.WriteLine(res);

            string a2 = "Test";
            a2 = a2 ?? "Нет данных!";
            Console.WriteLine(a2);
#endif

#if false

            // Объявление и инициализация, конструкторы, перебор символов
            string message = "Всем доброе утро!";
            Console.WriteLine(message);

            //for
            //foreach

            // Объединение строк: метод Concat или операторы + и +=
            message += "!!!!";
            Console.WriteLine(message);
            message = string.Concat(message, " Черная пятница!");
            Console.WriteLine(message);
            Console.WriteLine(string.Concat(message, " Черная пятница!"));

            // Для объединения последовательности(массива, коллекции) с разделителем,
            // можно использовать метод Join:
            // первый аргумент - разделитель для частей

            var result = string.Join(", ", "зима", "весна", "лето", "очень");
            Console.WriteLine(result);

            string[] mas = new string[] { "Маркс", "Рыжик", "Скителс", "Пират" };
            result = string.Join("; ", mas);
            Console.WriteLine(result);

            int[] mi = new int[] { 1, 2, 3, 4, 5, };
            result = string.Join("  ", mi);
            Console.WriteLine(result);

            //Смена регистра   ToLower   ToUpper

            Console.WriteLine( message.ToUpper());

            Console.WriteLine(message.ToLower());

            message = message.ToLower();
            message = char.ToUpper(message[0]) + message.Substring(1);
            Console.WriteLine(message);

            // ToCharArray() - получаем из строки массив символов
            char[]mas_char=message.ToCharArray();
            Console.WriteLine("Массив символов: ",mas_char);
            Console.WriteLine(string.Join(", ",mas_char));

            // Задача: осуществить реверс строки
            string test = "Скоро Новый Год!";
            Console.WriteLine(test);

            char[] mas_char2 = test.ToCharArray();
            Array.Reverse(mas_char2);
            Console.WriteLine(mas_char2);
            string res = new string(mas_char2);
            Console.WriteLine("Строка: {0}", res);
            Console.WriteLine();

            //Console.WriteLine("test:{0}",test);
            //test.Reverse();
            //Console.WriteLine(test.ToString());

            // Метод CopyTo — копирует заданное количество символов в массив типа char.
            char[]mas_char3 = new char[20];
            test = "Скоро Новый Год!";
            // с 6-го индекса строки скопировали 5 символов в массив символов с индекса 0
            test.CopyTo(6, mas_char3, 0, 5);
            Console.WriteLine(mas_char3);
            
#endif

#if false

            // Сравнение строк
            // 1.  операторы ==  и !=
            string a = "apple";
            string b = "apple";

            Console.WriteLine(a==b);//True
            Console.WriteLine(a=="APPLE"); // False

            //Console.WriteLine(a>b);// ошибка

            // 2. Equals – сравнивает на идентичность две строки(аналог оператора ==).
            //    При сравнении учитывается регистр символов.

            //    Equals - может принимать дополнительный параметр StringComparison,
            //    который определяет настройки сравнения.

            Console.WriteLine(a.Equals("APPLE"));// False с учетом регистра
            Console.WriteLine(a.Equals("APPLE",StringComparison.OrdinalIgnoreCase));// True  без учета регистра

            //3.  Compare - может принимать дополнительный параметр StringComparison 
            Console.WriteLine(string.Compare("apple", "banana"));//<   -1
            Console.WriteLine(string.Compare("apple", "apple"));//=  0
            Console.WriteLine(string.Compare("banana", "apple"));//>  1
            Console.WriteLine(string.Compare("apple", "Apple",StringComparison.OrdinalIgnoreCase));//0

            //4. CompareOrdinal - делает то же, что и метод Compare(),
            //   но без учета локальных установок
            Console.WriteLine(string.CompareOrdinal("apple", "Apple"));//32

            //5.  CompareTo   выполняет сравнение строк только с учетом культурной среды.
            a = "apple";
            Console.WriteLine(a.CompareTo("ananas"));//1
            Console.WriteLine();

            //Задача: отсортировать массив строк
            string[] mas = new string[] { "Маркс", "рыжик", "Скителс", "Пират", "атлант" };

            //Array.Sort(mas);// В алфавитном порядке без учета регистра
            //Array.Sort(mas, (x,y) => y.CompareTo(x));  // В обратном алфавитном порядке без учета региста
            Array.Sort(mas,StringComparer.Ordinal);// В алфавитном порядке c учетом регистра

            foreach (string s in mas)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            //-------------------------------------------------------------------------
            // Основные методы строк

            //Split - разделяет одну строку на массив строк (Си - лексемы )
            string cat = "    Все с             уважением          отсносятся к коту, за то, " +
                "что кот любит чистоту.           \nМаяковский. ";

            string[]arrStr =  cat.Split(" !,?;".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in arrStr)
            {
                Console.WriteLine(item); 
            }

            
            //StartsWith и EndsWith
            // Задача: В массиве строк хранятся имена файлов, вывести все с расширением .exe
            string t = "dictionary.txt";
            Console.WriteLine( t.EndsWith("txt") );// True

            //IndexOf - поиск в строке символа или подстроки в строке  
            Console.WriteLine( t.IndexOf(".txt"));

            // Обрезка строки:
            //1. Пробелы: Trim    TrimStart   TrimEnd
            //2. Substring
            t = "             dictionary.txt      test.bin                  ";
            Console.WriteLine( t.Trim());

            t = t.Trim();
            Console.WriteLine(t);
            t = t.Substring(10, 4);
            Console.WriteLine(t);// вырезать из строки подстроку

            //Insert - вставка строки 
            string d = "день";
            d = d.Insert(0, "Очень хороший ");
            Console.WriteLine(d);

            //Remove - удаление части строки 
            //Console.WriteLine( d.Remove(0, 5));
            
            Console.WriteLine( d.Remove(5));// удаление части строки с 5-го индекса до конца

            //Replace - замена
            string text = "Человек сказал - Человек сделал! ";
            text = text.Replace("Человек", "Кот");

            Console.WriteLine(text);

            // Дополнение строк:
            //  PadLeft – возвращает новую строку в дополненную слева указанными символами;
            //  PadRight – дополняет указанными символами справа.
            //  Если символ для дополнения не указан, используется пробел.

            //  Эти методы удобно использовать для вывода
            //  чисел и текста с выравниванием

            string num = "123";
            Console.WriteLine(num.PadLeft(10));// пробел - по умолчанию
            Console.WriteLine(num.PadLeft(10,'0'));
            Console.WriteLine(num.PadRight(10,'*'));

            //---------Форматирование и интерполяция строк-----------------
            // Форматирование валюты
            // Формат процентов
            // Настраиваемые форматы
            // Интерполяция строк
            /*
             Знак доллара перед строкой указывает, что будет осуществляться интерполяция строк. 
            Внутри строки опять же используются плейсхолдеры {...}, 
            только внутри фигурных скобок уже можно напрямую писать те выражения, 
            которые мы хотим вывести.
             */


            //--------------------------------------------------------------
            // Метод Format

            Console.WriteLine("\n\nВывод строки с разными спецификаторами формата:");
            double test1 = 99989.987;
            int test2 = 99999;
            Console.WriteLine(String.Format("c format: {0,15:C}", test1));
            Console.WriteLine("c format: {0,15:C}", test1);
            Console.WriteLine($"c format: {test1,15:C}");
            Console.WriteLine();


            Console.WriteLine(String.Format("D format: {0:D9}", test2));
            Console.WriteLine(String.Format("E format: {0:E}", test1));
            Console.WriteLine(String.Format("f format: {0:F2}", test1));
            Console.WriteLine(String.Format("G format: {0:G}", test1));
            Console.WriteLine(String.Format("N format: {0,15:N}", test2));
            Console.WriteLine(String.Format("P format: {0:P}", test1));
            Console.WriteLine(String.Format("X format: {0:X}", test2));
            Console.WriteLine(String.Format("x format: {0:x}", test2));

            int x = 25;
            string res_x = Convert.ToString(x, 2);
            Console.WriteLine(res_x);
            
#endif

            //--------------------------------------------------------------------
            // Задача: В строке записан массив целых. Создать на основе данных
            // строки массив целых, отсортиовать по возрастанию.

            string numbers = "12    89  -256   9854  23 98 -14";
            string [] mas = numbers.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Размер массива: {0}", mas.Length);
          
            int [] result = new int[mas.Length];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = int.Parse(mas[i]);
            }
            foreach (int i in result)
            {
                Console.Write($"{i} ");
            }
            //Array.Sort(result);
            //Array.Sort(result, (x,y)=> y - x);
            Array.Sort(result, (x,y)=> y.CompareTo(x));

            Console.WriteLine();
            foreach (int i in result)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
            //===========================================================

            //--------------------Динамическая строка--------------------
            // Capacity (Емкость) - это выделенная память под объект.
            // Установка емкости позволяет уменьшить выделения памяти и
            // тем самым повысить производительность.
                        
            // Append


            //StringBuilder sb = new StringBuilder();
            StringBuilder sb = new StringBuilder("Hello?", 60);
            Console.WriteLine("Capacity:{0}", sb.Capacity);
            Console.WriteLine("MaxCapacity:{0}", sb.MaxCapacity);

            Console.WriteLine(sb);
            sb[5]= '!';
            Console.WriteLine(sb);
            //sb += " ПРивет-привет!";
            sb.Append(" ПРивет-привет!");
            Console.WriteLine(sb);
            Console.WriteLine("Capacity:{0}", sb.Capacity);
            sb.Capacity = 100;

            Console.WriteLine("Capacity:{0}", sb.Capacity);



            //-----------------------------------------------------------------
            //AppendFormat

            StringBuilder sb4 = new StringBuilder();

            string name = "Александр";
            int age = 30;

            sb4.AppendFormat("Имя: {0}, Возраст: {1}", name, age);
            Console.WriteLine(sb4.ToString());

            //// Допустим, у нас есть другие данные для добавления
            double salary = 50000.50;
            sb4.AppendFormat(" Зарплата: {0:C}", salary);

            Console.WriteLine(sb4.ToString());

            //-----------------------------------------------------------------
            StringBuilder sb5 = new StringBuilder("Example");
            Console.WriteLine(sb5);

            StringBuilder sb6 = sb5; // копия ссылок
            sb5[0] = '*';
            Console.WriteLine(sb6);

            // Глубокая копия при использовании конструктора
            StringBuilder sb7 = new StringBuilder(sb5.ToString());
            sb5[0] = '#';
            Console.WriteLine(sb7);

           
            Console.ReadLine();

        }
    }
}
/*
             
C / c	Задает формат денежной единицы, указывает количество десятичных разрядов после запятой
D / d	Целочисленный формат, указывает минимальное количество цифр
E / e	Экспоненциальное представление числа, указывает количество десятичных разрядов после запятой
F / f	Формат дробных чисел с фиксированной точкой, указывает количество десятичных разрядов после запятой
G / g	Задает более короткий из двух форматов: F или E
N / n	Также задает формат дробных чисел с фиксированной точкой, определяет количество разрядов после запятой
P / p	Задает отображения знака процентов рядом с число, указывает количество десятичных разрядов после запятой
X / x	Шестнадцатеричный формат числа

 */

//=================================================================================
/*
Ссылочный тип данных string представляет последовательность из нуля 
или более символов в кодировке Unicode и является псевдонимом для класса System.String
платформы .NET Framework.

Содержимое объекта типа string не подлежит изменению!

Строка является неизменяемым объектом, это значит, 
что после создания её нельзя изменить, 
а любые изменения, к примеру объединение, 
приводят к созданию новой строки.

 */


//------------------null - string-------------------------------------
/*
Пустая строка и строка без значения:
 
Пустая строка – это объект типа string, 
в котором не содержится символов, её длина равна нулю.

В отличии от пустой строки, строка без значения(null - string), 
не ссылается на объект.
*/

/*
IsNullOrEmpty - проверка на пустоту

Для проверки на null и пустоту используется метод IsNullOrEmpty, 
он возвращает true если строка пуста или равна null.
*/


//------------------Сравнение строк--------------------------------------

/*
В классе String перегружаются два следующих оператора: == и !=. 

Оператор == служит для проверки двух символьных строк на равенство. 
Когда оператор == применяется к ссылкам на объекты, он обычно проверяет, 
делаются ли обе ссылки на один и тот же объект. 

А когда оператор == применяется к ссылкам на объекты типа String, 
то на предмет равенства сравнивается СОДЕРЖИМОЕ самих строк. 
Это же относится и к оператору !=. 

А для того чтобы проверить, является ли одна строка больше другой, 
следует вызвать метод Compare(), определенный в классе String.
 */

//-----------------------------------------------------------------------------
/*
 Итог:

- C# предлагает мощные средства для работы со строками, предоставляя операции редактирования, 
  сравнения, поиска для текстовых значений.

- По скольку тип string является неизменяемым, редактирование строки символов, 
  приводит к созданию нового объекта в памяти.

- При сравнении и поиске, учитывается регистр символов и региональные настройки, 
  при этом сравнение происходит в алфавитном порядке, как это принято в сортировке по возрастанию.

- Строку можно рассматривать как символьный массив, к элементам которого, 
  можно обращаться по индексу, при этом доступно только чтение данных.
 
 */

//--------------------------------------------------------------------
/*
 Основные методы строк:

        Compare: сравнивает две строки с учетом текущей культуры (локали) пользователя

        CompareOrdinal: сравнивает две строки без учета локали

        Contains: определяет, содержится ли подстрока в строке

        Concat: соединяет строки

        CopyTo: копирует часть строки, начиная с определенного индекса в массив

        EndsWith: определяет, совпадает ли конец строки с подстрокой

        Format: форматирует строку

        IndexOf: находит индекс первого вхождения символа или подстроки в строке

        Insert: вставляет в строку подстроку

        Join: соединяет элементы массива строк

        LastIndexOf: находит индекс последнего вхождения символа или подстроки в строке

        Replace: замещает в строке символ или подстроку другим символом или подстрокой

        Split: разделяет одну строку на массив строк

        Substring: извлекает из строки подстроку, начиная с указанной позиции

        ToLower: переводит все символы строки в нижний регистр

        ToUpper: переводит все символы строки в верхний регистр

        Trim: удаляет начальные и конечные пробелы из строки
 */
