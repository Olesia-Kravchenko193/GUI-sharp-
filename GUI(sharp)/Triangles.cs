using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_sharp_
{
    class Triangles
    {
        public double side, h, squares, a, b, c;
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
                    max = i;
            }
            return max;
        }
       
        public void getRight_triangleTriangles(Triangles[] M_triangles)
        {
            Random r = new Random();
            for (int i = 0; i < M_triangles.Length; i++)
            {
                M_triangles[i] = new Triangles();
                M_triangles[i].a = r.Next(2, 10);
                M_triangles[i].b = r.Next(2, 10);
                M_triangles[i].c = Math.Sqrt(M_triangles[i].a * M_triangles[i].a + M_triangles[i].b * M_triangles[i].b);
            }
        }
        public int getMinHypotenuse(Triangles[] M_triangles)
        {
            int min = 0;
            for (int i = 0; i < M_triangles.Length; i++)
            {
                if (M_triangles[min].c > M_triangles[i].c)
                    min = i;
            }
            return min;
        }

    }
}
