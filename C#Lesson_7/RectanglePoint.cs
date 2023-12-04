using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _6_2_Use_Point;

namespace _7_2_Use_RectanglePoint
{
    internal class RectanglePoint
    {
        private Point topLeft;// = new Point();

        public Point TopLeft
        {
            get { return topLeft; }
            set { topLeft = value; }
        }

        private Point bottomRight;// = new Point();

        public Point BottomRight
        {
            get { return bottomRight; }
            set { bottomRight = value; }
        }

        public RectanglePoint():this(new Point(0,0),new Point(1, 1)) { }
        public RectanglePoint(Point topLeft, Point bottomRight)
        {
            TopLeft = topLeft;// Свойство
            this.bottomRight = bottomRight;// поле
        }
        public RectanglePoint(RectanglePoint obj)
        {
            topLeft = new Point(obj.topLeft.X, obj.topLeft.Y);
            BottomRight = new Point(obj.bottomRight.X, obj.bottomRight.Y);

            // это копия ссылок, неверно
            //TopLeft = obj.TopLeft;
            //BottomRight = obj.BottomRight;
        }

        public override string ToString()
        {
            //return $"{topLeft} {bottomRight}";
            return $"topLeft: {topLeft.X}; {topLeft.Y} "
                + $"bottomRight: { bottomRight.X}; {bottomRight.Y}";          
        }
    }
}
