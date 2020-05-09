namespace GUI_sharp_
{
    internal class Right_Triangle : Triangle
    {
        public Right_Triangle(double a, double b, double c) : base(a, b, c)
        {

        }
        public Right_Triangle() : base()
        {

        }
        public override string ToString()
        {
            return "a = " + this.a + "; \nb = " + this.b + "; \nc = " + this.c + ";";
        }
        public bool isRight_triangle()
        {
            if (a * a + b * b == c * c || b * b + c * c == a * a || c * c + a * a == b * b)
            {
                return true;
            }

            return false;
        }

    }
}
