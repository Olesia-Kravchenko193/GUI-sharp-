using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_sharp_
{
    class Triangle
    {
        public double a;
        public double b;
        public double c;
        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }

        public Triangle(double a, double b, double c) 
        {
            A = a;
            B = b;
            C = c;
        }
        public Triangle()
        {

        }
        public override string ToString()
        {
            return  "a = " + this.a + "; \nb = " + this.b + "; \nc = " + this.c + ";";
        }
        public bool isExists()
        {
            if (a + b > c && a + c > b && b + c > a)
                return true;
            else
                return false;
        }
        public double getSquare()
        {
            double p = (a + b + c) / 2;
            return  Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public double getPerimeter()
        {
            return (a + b + c);
        }

        public double getAngle1()
        {
            return Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * 180 / Math.PI;
        }
        public double getAngle2()
        {
            return Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * 180 / Math.PI;
        }
        public double getAngle3()
        {
            return Math.Acos((b * b + c * c - a * a) / (2 * c * b)) * 180 / Math.PI;
        }
    }

}
