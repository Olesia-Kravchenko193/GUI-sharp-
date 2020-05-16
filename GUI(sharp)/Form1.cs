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
        OpenFileDialog open = new OpenFileDialog();
        SaveFileDialog save = new SaveFileDialog();
        Triangle triangle = new Triangle();
        public Form1()
        {
            InitializeComponent();          
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                triangle = new Triangle(Double.Parse(textBox_a.Text), Double.Parse(textBox_b.Text), Double.Parse(textBox_c.Text));
                MessageBox.Show(triangle.ToString());
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
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
            textBox_Angle1.Text = $"{String.Format("{0:0.00}", triangle.getAngle1())} градусов";
            textBox_Angle2.Text = $"{String.Format("{0:0.00}", triangle.getAngle2())} градусов";
            textBox_Angle3.Text = $"{ String.Format("{0:0.00}", triangle.getAngle3())} градусов";
        }

        private void TransitionButton1_Click(object sender, EventArgs e)
        {
            save.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            DialogResult result = MessageBox.Show("Сохранить значения в файл?", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string filename = save.FileName;
                    string[] temp = { "Triangle: ", textBox_a.Text, textBox_b.Text, textBox_c.Text, textBox_isExists.Text, "S = " + textBox_Square.Text, "P = " + textBox_Perimeter.Text, textBox_Angle1.Text, textBox_Angle2.Text, textBox_Angle3.Text + "\n" };

                    System.IO.File.WriteAllLines(filename, temp);
                    MessageBox.Show("Файл сохранен");
                }
            }
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            save.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            DialogResult result = MessageBox.Show("Сохранить значения в файл?", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string filename = save.FileName;
                    string[] temp = { "Triangle: ", textBox_a.Text, textBox_b.Text, textBox_c.Text, textBox_isExists.Text, "S = " + textBox_Square.Text, "P = " + textBox_Perimeter.Text, textBox_Angle1.Text, textBox_Angle2.Text, textBox_Angle3.Text + "\n" };

                    System.IO.File.WriteAllLines(filename, temp);
                    MessageBox.Show("Файл сохранен");
                }
            }
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            open.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            DialogResult result = MessageBox.Show("Загрузить значения из файла?", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    string filename = open.FileName;

                    textBox_a.Text = System.IO.File.ReadLines(filename).Skip(1).FirstOrDefault();
                    textBox_b.Text = System.IO.File.ReadLines(filename).Skip(2).FirstOrDefault();
                    textBox_c.Text = System.IO.File.ReadLines(filename).Skip(3).FirstOrDefault();
                }
            }
        }

    }
}
