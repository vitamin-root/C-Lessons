using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
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
    internal class Bank
    {
        private double currentBalance;

        private static readonly double bonus;// = 4.5; // поле
        
        private static readonly double bonusPersonal;// свойство

        public static double BonusPersonal
        {
            get { return bonusPersonal/100; }
            //set { bonusPersonal = value; }
        }


        public double CurrentBalance
        {
            get { return currentBalance; }
            private set { currentBalance = value; }
        }

        public Bank(double currentBalance = 0)
        {
            //bonus = 4.5; // ошибка
            //bonusPersonal = 5.6;
            Console.WriteLine("Конструктор");
            this.currentBalance = currentBalance;
        }

        static Bank()
        {
            Console.WriteLine("Статический конструктор");
            bonus = 4.5;
            bonusPersonal = 5.6;
            //this.currentBalance = currentBalance;
        }

        public double GetPercents(double summa)
        {
            if(summa < currentBalance)
            {
                double percent = summa * bonus / 100;
                currentBalance -= percent;
                return percent;
            }
            return -1;
        }
        public static double GetBonus() => bonus/100;
    }

    // Статический конструктор----------------------------------------

    //- нет модификатора доступа
    //- только один в классе
    //- не может принимать параметры
    //- выполняется всегда только один раз за всю работу программы,
    //  как только было взаимодействие с классом
    //- не можем в нем обращаться к нестатическим членам класса
    //- для инициализации статических полей, свойств (readonly в том числе)
    //  если на момент написания кода у нас этих данных нет
    //  (например считыаются из файла)

}
