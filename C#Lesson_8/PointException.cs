using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_4_MyException
{
    internal class PointException : ApplicationException
    {
        //1------------------------------------
        //    string message;
        //    public int XErr { get; private set; }
        //    public int YErr { get;}
        //    public DateTime DateException { get;  }
        //    public PointException(string message, int v)
        //    {
        //        if(message == "X")
        //            XErr = v;
        //        if (message == "Y")
        //            YErr = v;
        //        this.message = message;
        //        DateException = DateTime.Now;
        //    }
        //    public PointException(string message, int x, int y)
        //    {
        //        XErr = x;
        //        YErr = y;
        //        this.message = message;
        //        DateException = DateTime.Now;
        //    }
        //    public override string Message
        //    {
        //        get { return "Отрицательное значение координаты!"; }
        //    }

        //2----------------------------
       
        public int XErr { get; private set; }
        public int YErr { get; }
        public DateTime DateException { get; }
        public PointException(string message, int v) : base(message)
        {
            if (message == "X")
                XErr = v;
            if (message == "Y")
                YErr = v;
            
            DateException = DateTime.Now;
        }
        public PointException(string message, int x, int y) : base(message)
        {
            XErr = x;
            YErr = y;
           
            DateException = DateTime.Now;
        }
       
    }
}

