using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_4_MyException
{
    internal class PointPos
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set {
                x = value;
                if (value < 0 )
                    throw new PointException("X", X);
            }
        }

        public int Y {
            get 
            {
                return y;
            }
            set
            {
                y = value;
                if (value < 0)
                    throw new PointException("Y", Y);
            }
        }

        public PointPos(int x, int y)
        {
            //1 
            //this.x = x;//поле
            //this.X = x;  //Свойство
            //this.Y = y;  // Свойство 

            //2
            if(x > 0 && y> 0)
            {
                this.x = x;
                this.y = y;
            }
            else throw new PointException("Отрицательное значение!", x , y);
        }
    }
}
