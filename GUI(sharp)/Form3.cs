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
        OpenFileDialog open = new OpenFileDialog();
        SaveFileDialog save = new SaveFileDialog();
        Triangles triangles = new Triangles();
        Right_Triangle right_triangle = new Right_Triangle();

        public Form3()
        {
            InitializeComponent();
        }
        private void InitButton_Click(object sender, EventArgs e)
        {
            try
            {
                int N = Convert.ToInt32(textBox_Quantity_N.Text);
                Triangles[] N_triangles = new Triangles[N];

                int M = Convert.ToInt32(textBox_Quantity_M.Text);
                Right_Triangle[] M_right_triangle = new Right_Triangle[M];
           
            triangles.getTriangles(N_triangles);
            triangles.getRight_triangleTriangles(M_right_triangle);

            
            for (int i = 0; i < N_triangles.Length; i++)
            {
                textBox_infoN.Text += $"side[{i + 1}] = {N_triangles[i].side}cm, h[{i + 1}] = {N_triangles[i].h}cm;       ";
            }
            for (int i = 0; i < M_right_triangle.Length; i++)
            {
                textBox_infoM.Text += $"a[{i + 1}] = {M_right_triangle[i].a}cm, b[{i + 1}] = {M_right_triangle[i].b}cm, c[{i + 1}] = {String.Format("{0:0.00}", M_right_triangle[i].c)}cm;        ";
            }


              labelMAX_number.Text = $"{triangles.getMAXsquare(N_triangles) + 1}";
              textBox_maxS.Text =  $" S = {N_triangles[triangles.getMAXsquare(N_triangles)].squares} cm^2";

            labelMIN_number.Text = $"{triangles.getMinHypotenuse(M_right_triangle) + 1}";
               textBox_minGipotenus.Text = $" c = {String.Format("{0:0.00}", M_right_triangle[triangles.getMinHypotenuse(M_right_triangle)].c)} cm";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void ExitButton3_Click(object sender, EventArgs e)
        {
            save.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            DialogResult result3 = MessageBox.Show("Сохранить значения в файл?", "", MessageBoxButtons.YesNo);

            if (result3 == DialogResult.Yes)
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string filename = save.FileName;
                    string[] temp3 = { "Triangles: ", textBox_Quantity_N.Text, textBox_Quantity_M.Text, textBox_infoN.Text, "MAX площадь: " + textBox_maxS.Text, textBox_infoM.Text, "Найменьшая гипотенуза: " + textBox_minGipotenus.Text + "\n" };

                    System.IO.File.AppendAllLines(filename, temp3);
                    MessageBox.Show("Файл сохранен");
                }
            }
            Application.Exit();
        }

        private void OpenFileButton3_Click(object sender, EventArgs e)
        {
            open.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            if (open.ShowDialog() == DialogResult.OK)
            {
                string filename = open.FileName;

                textBox_Quantity_N.Text = System.IO.File.ReadLines(filename).Skip(18).FirstOrDefault();
                textBox_Quantity_M.Text = System.IO.File.ReadLines(filename).Skip(19).FirstOrDefault();

            }
        }
    }
}
