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
    public partial class Form2 : Form
    {
        Right_Triangle right_triangle = new Right_Triangle();
        public Form2()
        {
            InitializeComponent();
        }

        private void ExitButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaveButton2_Click(object sender, EventArgs e)
        {
            try
            {
                right_triangle = new Right_Triangle(Double.Parse(textBox_a.Text), Double.Parse(textBox_b.Text), Double.Parse(textBox_c.Text));
                MessageBox.Show(right_triangle.ToString());
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            if (right_triangle.isExists())
            {
                if (right_triangle.getRight_triangle())
                    textBox_right.Text = "Треугольник прямоугольный";
                else
                    textBox_right.Text = "Треугольник НЕ прямоугольный";
            }
            else
                textBox_right.Text = "Треугольник НЕ существует";
        }

        private void TransitionButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void backButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }


    }
}
