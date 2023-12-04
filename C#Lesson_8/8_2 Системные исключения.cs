using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
try
{

}
catch (тип ex)
{

}
catch (тип ex) when(условие)   // фильтр исключения
{

}
catch //
{

}
finally
{
 // выполняется всегда
}

*/

namespace _8_2_Системные_исключения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("double.Epsilon " + double.Epsilon);
            Console.WriteLine("double.PositiveInfinity " + double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity " + double.NegativeInfinity);
            Console.WriteLine("double.NaN " + double.NaN);

	        string errType;
            do
            {
                Console.WriteLine("\nВыберите тип ошибки");
                Console.WriteLine("1. Деление на нуль int");
                Console.WriteLine("2. Выход за границы массива");
                Console.WriteLine("3. Неправильное приведение типов");
                Console.WriteLine("4. Отрицательный размер массива");
                Console.WriteLine("5. Использование ссылки null массив");
                Console.WriteLine("6. Использование ссылки null строка");
                Console.WriteLine("7. Деление на нуль decimal");
                Console.WriteLine("8. Деление на нуль double");
                Console.WriteLine("0. Завершить работу программы");

                errType = Console.ReadLine();

                try
                {
                    switch (errType)
                    {
                        case "1": { int i = 0; int res = 5 / i; break; } //  Деление на нуль

                        case "2": { int[] array = new int[5]; array[6] = 0; break; } // Выход за пределы массива

                        case "3": { Object ch = new Char(); ch = "+"; byte b = (byte)ch; break; }// Ошибка приведения типа

                        case "4": { int i = -5; int[] array = new int[i]; array[0] = 0; break; } // Отрицательный размер массива

                        //case "5": { int[] array = null; array[0] = 0; break; }// Использование ссылки null
                        case "5": { 
                                int[] array = null; 
                                if(array == null)
                                    throw new ArgumentNullException(nameof(array));
                                array[0] = 0; break; }// Использование ссылки null

                      case "6": {
                      string s = null;
                      //Console.Write($"Строка: {s.ToUpper()}");
                      Console.Write($"Строка: {s?.ToUpper()??"нет данных в строке"}");
                      break;
                        }// Использование ссылки null

                        case "7": { decimal i = 0; decimal res = 5 / i; break; } //  Деление на нуль
                        case "8": { double i = 5.0; double res = 0.0 / i;
                                Console.WriteLine($"Результат деления: {res}");
                                if (double.IsInfinity(res))
                                    throw new ArgumentNullException(nameof(res));
                                break; } //  Деление на нуль
                    }
                }
                catch (DivideByZeroException exp)
                {
                    Console.WriteLine(">>>> Делить на нуль нельзя!");
                    Console.WriteLine(exp.Message);
                }
                catch (IndexOutOfRangeException exp)
                {
                    Console.WriteLine(">>>> Выход за пределы массива!");
                    Console.WriteLine(exp.Message);
                }
                catch (OverflowException exp)
                {
                    Console.WriteLine(">>>> Отрицательный массива!");
                    Console.WriteLine(exp.Message);
                }
                catch(InvalidCastException exp)
                {
                    Console.WriteLine(">>>> Неверное приведение типов!");
                    Console.WriteLine(exp.Message);
                }
                catch (NullReferenceException exp)//!!!
                {
                    Console.WriteLine(exp.Message);
                }
                catch (Exception exp) 
                {
                    //Console.WriteLine(">>>> Неверное приведение типов!");// лучше не давать сообщение спец. исключениям
                    Console.WriteLine(exp.Message);
                }
              
                // Для обработки всех типов исключений
                // заключительный блок catch  -  не рекомендуется
                //catch
                //{
                //    Console.WriteLine("Ошибка!!!");
                //}
                finally
                {
                    // освобождение неуправляемых ресурсов
                    Console.WriteLine("Блок finally");
                }
                Console.ReadLine();
                Console.Clear();

            } while (errType != "0");

            Console.ReadLine();
        }
    }
}
