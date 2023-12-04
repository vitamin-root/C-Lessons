using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_Use_Point
{
    internal class Point //: Object
    {
        private int x;// поле
        public int X //свойство
        {
            get { return x; }
            set { x = value; }
        }

        private int y;// поле
        public int Y  // свойство
        {
            get { return y; }
            set { y = value; }
        }
        //public string Name { get; private set; }

        // Делегирующий конструктор
        public Point(): this(1,1){}
        public Point (int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Point (Point obj)
        {
            x = obj.x;
            y = obj.y;
        }
        public override string ToString()
        {
            //return base.ToString();
            return $"[{X};{y}]";
        }
    }
}
