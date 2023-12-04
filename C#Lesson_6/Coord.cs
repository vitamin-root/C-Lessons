using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_Классы
{
    internal class Coord
    {
        static int Count = 0;//private - по умолчанию

        public static int MAX;// = 500;
        public const int MIN = -500;// по умолчанию - это static

        public readonly string name = "no name";// не статическое поле, только для чтения
        public  const double kf = 1.5;// по умолчанию - это static

        private double x;
        private double y;
        private double z;

        public void SetX(double _x)
        {
            //this.x = _x;
            if (_x < MAX) x = _x;
            else x = MAX;
        }
        public double GetX()
        { 
            return this.x;
        }
        public void SetY(double y)=>this.y = y;
        public double GetY() => this.y;

        public void SetZ(double _z) => z = _z;
        public double GetZ() => z;

        //public static int GetCount() => Count;
        public static int GetCount()
        {
            //this; // нет доступа по this
            return Count;
        }
        public Coord(double _x=1,double y=1, double z=1)
        {
            Console.WriteLine("Конструтор");
            name = "центр круга";
            MAX = 100;// 
            x = _x;
            this.y = y;
            this.z = z;
            Count++;
        }

        public Coord(Coord obj)
        {
            Console.WriteLine("Конструтор копий");
            this.x = obj.x; 
            this.y = obj.y;
            this.z = obj.z;
            Count++;
        }
        public Coord Copy()
        {
            Coord coord = new Coord(this.x,this.y,this.z);
            return coord;

           //return new Coord(this);
           //return new Coord(x,y,z);
        }
        public void Show()
        {
            //name = "центр круга"; // ошибка
            //MAX = 100;
            Console.WriteLine($"[{x:F2}; {y:F2}; {z:F2}]");
        }

        public void Deconstruct(out double x, out double y, out double z)
        {
            x = this.x;
            y = this.y;
            z = this.z;
        }
        ~Coord()
        {
            Console.WriteLine("Деструктор");
            Console.ReadLine();
        }
    }
}
