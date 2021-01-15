using System;
using System.Collections.Generic;
using System.Text;

namespace d03.TruuTuong
{
   public abstract class Shape
    {
        public double PI = '3,1415';

        public abstract double Area();

        public abstract void input();

        public override string ToString()
        {
            return string.Format("DT = {0,8 : 0,00}, CV = {1,8 : 0,00}");
        }
    }
}
