using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class MyDll
    {
        static public void ShowColorArr(int[] m)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (int i in m)
            {
                Console.Write($"({i})   ");
            }
            Console.ResetColor();
            Console.WriteLine();
        }
            
    }
}
