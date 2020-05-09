using System;

namespace GUI_sharp_
{
    internal class Triangles
    {
        public double side, h, squares;
        public void getTriangles(Triangles[] N_triangles)
        {
            Random r = new Random();
            for (int i = 0; i < N_triangles.Length; i++)
            {
                N_triangles[i] = new Triangles();
                N_triangles[i].side = r.Next(2, 10);
                N_triangles[i].h = r.Next(2, 10);
                N_triangles[i].squares = (N_triangles[i].side * N_triangles[i].h) / 2;
            }
        }

        public int getMAXsquare(Triangles[] N_triangles)
        {
            int max = 0;
            for (int i = 0; i < N_triangles.Length; i++)
            {
                if (N_triangles[max].squares < N_triangles[i].squares)
                {
                    max = i;
                }
            }
            return max;
        }

        public void getRight_triangleTriangles(Right_Triangle[] M_right_triangle)
        {
            Random r = new Random();
            for (int i = 0; i < M_right_triangle.Length; i++)
            {
                M_right_triangle[i] = new Right_Triangle();
                do
                {
                    M_right_triangle[i].a = r.Next(2, 10);
                    M_right_triangle[i].b = r.Next(2, 10);
                    M_right_triangle[i].c = Math.Sqrt(M_right_triangle[i].a * M_right_triangle[i].a + M_right_triangle[i].b * M_right_triangle[i].b);
                }
                while (!M_right_triangle[i].isRight_triangle());
            }
        }
        public int getMinHypotenuse(Right_Triangle[] M_right_triangle)
        {
            int min = 0;
            for (int i = 0; i < M_right_triangle.Length; i++)
            {
                if (M_right_triangle[min].c > M_right_triangle[i].c)
                {
                    min = i;
                }
            }
            return min;
        }

    }
}
