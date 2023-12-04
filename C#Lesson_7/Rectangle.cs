using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_Классы
{
    internal class Rectangle
    {
        //public int MyProperty { set; }//error
        public int Perimetr {
            get
            {
                //width = 0;
                return 2*(width + height);
            }  
        }
        public int Square { get => width * height; } 
                

        private int height;

        public int Height
        {
            get { return height; }
            set { 
                if(value < 0)
                {
                    throw new ArgumentException($"Отрицательное значение высоты: {nameof(value)} {value}");
                }
                height = value; 
            }
        }

        private int width;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public Rectangle(int height = 1, int width = 1)
        {
            //if(height < 0)
            //{
            //    throw new ArgumentException($"Отрицательное значение высоты: {nameof(height)} {height}");
            //}
            //this.height = height;// инициализация поля
            this.Height = height; // свойство
            this.width = width;
        }
        public  Rectangle(Rectangle rect)
        {
            if(rect == null)
            {
                throw new ArgumentNullException($"{nameof(rect)} Нулевая ссылка! ");
            }
            this.height = rect.Height;
            width = rect.Width;
        }
        public override string ToString()
        {
            return $"Высота: {height} Ширина: {width}";
        }
    }
}
