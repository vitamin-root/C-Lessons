using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_3_checked
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = int.MaxValue;
            a++;
            Console.WriteLine(a);
            a = unchecked(a++);
            Console.WriteLine(a);
            Console.WriteLine();

            int b = int.MinValue;
            Console.WriteLine(b);
            //b = checked(b--);//OverflowException
            try
            {
                b = checked(b--);//OverflowException
                Console.WriteLine(b);
            }
            catch (OverflowException exp)
            {
                Console.WriteLine(exp.Message);
            }

            Console.WriteLine();

            double d = double.MaxValue;
            Console.WriteLine(d);
            d *= 2;
            Console.WriteLine(d);//?
            Console.WriteLine(double.IsInfinity(d));// True


            //  decimal - всегда исключение
            decimal dec = decimal.MaxValue;
            Console.WriteLine(dec);
            //dec *= 2;               //OverflowException
            dec = unchecked(dec*=2);  //OverflowException
            Console.WriteLine(dec);



            Console.ReadLine();
        }
    }
}
