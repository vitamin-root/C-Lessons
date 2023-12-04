using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Реализовать класс, описывающий банковские филиалы(БАНК).

Статическое поле(свойство) будет содержать бонус в процентах
для оформления депозитов. 

А текущий баланс у каждого филиала будет свой.

Характеристики:
    - текущий баланс 
    - статическое поле бонус

    - конструктор
    - методы set/get   или свойства
    - статический конструктор для иниц. стат. поля
    - метод для расчета процента
 */

namespace _7_3_Use_Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank(1000000);
            //Bank bank1 = new Bank
            //{
            //    CurrentBalance = 800000
            //};
            Console.WriteLine("Текущий баланс: {0:C}", bank.CurrentBalance);
            Console.WriteLine("Бонус: {0:P}", Bank.GetBonus());
            double depozit = 50000;
            Console.WriteLine($"Ваш доход: {bank.GetPercents(depozit)} " +
                $"по сумме вклада {depozit}");
            Console.WriteLine("Текущий баланс: {0:C}", bank.CurrentBalance);
            Console.WriteLine();

            Bank bank2 = new Bank(56000000);
            Console.WriteLine("Текущий баланс: {0:C}", bank2.CurrentBalance);
            Console.WriteLine("Бонус: {0:P}", Bank.GetBonus());

            Console.WriteLine();

            Console.WriteLine("\nБонусPersonal: {0:P}", Bank.BonusPersonal);

            Console.ReadLine();
        }
    }
}
