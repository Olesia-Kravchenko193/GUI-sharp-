using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_sharp_
{
    class Right_Triangle : Triangle
    {
        public Right_Triangle(double a, double b, double c)//конструктор
        {
            A = a;
            B = b;
            C = c;
        }
        public Right_Triangle()
        {

        }
        public override string ToString()
        {
            return "a = " + this.a + "; \nb = " + this.b + "; \nc = " + this.c + ";";
        }
            public bool getRight_triangle()
            {
                if (a * a + b * b == c * c || b * b + c * c == a * a || c * c + a * a == b * b)
                    return true;
                else
                    return false;
            }
        
    }
}
