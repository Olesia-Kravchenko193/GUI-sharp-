using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_sharp_
{
    public partial class Form3 : Form
    {
        Triangles triangles = new Triangles();

        public Form3()
        {
            InitializeComponent();
        }
        private void ExitButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InitButton_Click(object sender, EventArgs e)
        {
            try
            {
                int N = Convert.ToInt32(textBox_Quantity_N.Text);
                Triangles[] N_triangles = new Triangles[N];

                int M = Convert.ToInt32(textBox_Quantity_M.Text);
                Triangles[] M_triangles = new Triangles[M];
           
            triangles.getTriangles(N_triangles);
            triangles.getRight_triangleTriangles(M_triangles);

            
            for (int i = 0; i < N_triangles.Length; i++)
            {
                textBox_infoN.Text += $"side[{i + 1}] = {N_triangles[i].side}cm, h[{i + 1}] = {N_triangles[i].h}cm;       ";
            }
            for (int i = 0; i < M_triangles.Length; i++)
            {
                textBox_infoM.Text += $"a[{i + 1}] = {M_triangles[i].a}cm, b[{i + 1}] = {M_triangles[i].b}cm, c[{i + 1}] = {String.Format("{0:0.00}", M_triangles[i].c)}cm;        ";
            }


              labelMAX_number.Text = $"{triangles.getMAXsquare(N_triangles) + 1}";
              textBox_maxS.Text =  $" S = {N_triangles[triangles.getMAXsquare(N_triangles)].squares} cm^2";

            labelMIN_number.Text = $"{triangles.getMinHypotenuse(M_triangles) + 1}";
               textBox_minGipotenus.Text = $" c = {String.Format("{0:0.00}", M_triangles[triangles.getMinHypotenuse(M_triangles)].c)} cm";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

    }
}
