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
    public partial class Form1 : Form
    {
       
        Triangle triangle = new Triangle();
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            triangle = new Triangle(Double.Parse(textBox_a.Text), Double.Parse(textBox_b.Text), Double.Parse(textBox_c.Text));
            MessageBox.Show(triangle.ToString());
        }

        private void isExistsButton_Click(object sender, EventArgs e)
        {
            
            if (triangle.isExists())
            {
                textBox_isExists.Text = "Треугольник существует";
            }
            else
                textBox_isExists.Text = "Треугольник НЕ существует";
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            textBox_Square.Text = $"{String.Format("{0:0.00}", triangle.getSquare().ToString())} cm^2";
        }

        private void PerimeterButton_Click(object sender, EventArgs e)
        {
            textBox_Perimeter.Text = $"{String.Format("{0:0.00}", triangle.getPerimeter().ToString())} cm";
        }

        private void AngleButton_Click(object sender, EventArgs e)
        {
            textBox_Angle1.Text = $"{String.Format("{0:0.00}", triangle.getAngle1().ToString())} градусов";
            textBox_Angle2.Text = $"{String.Format("{0:0.00}", triangle.getAngle2().ToString())} градусов";
            textBox_Angle3.Text = $"{ String.Format("{0:0.00}", triangle.getAngle3().ToString())} градусов";
        }

        private void TransitionButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
