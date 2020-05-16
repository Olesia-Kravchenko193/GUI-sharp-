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
        OpenFileDialog open = new OpenFileDialog();
        SaveFileDialog save = new SaveFileDialog();
        Right_Triangle right_triangle = new Right_Triangle();
        public Form2()
        {
            InitializeComponent();
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
                if (right_triangle.isRight_triangle())
                    textBox_right.Text = "Треугольник прямоугольный";
                else
                    textBox_right.Text = "Треугольник НЕ прямоугольный";
            }
            else
                textBox_right.Text = "Треугольник НЕ существует";
        }

        private void TransitionButton2_Click(object sender, EventArgs e)
        {
            save.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            DialogResult result2 = MessageBox.Show("Сохранить значения в файл?", "", MessageBoxButtons.YesNo);

            if (result2 == DialogResult.Yes)
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string filename = save.FileName;
                    string[] temp2 = { "Right triangle: ", textBox_a.Text, textBox_b.Text, textBox_c.Text, textBox_right.Text + "\n" };

                    System.IO.File.AppendAllLines(filename, temp2);
                    MessageBox.Show("Файл сохранен");
                }
            }
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void backButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.form1.Show();
        }

        private void ExitButton2_Click(object sender, EventArgs e)
        {
            save.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            DialogResult result2 = MessageBox.Show("Сохранить значения в файл?", "", MessageBoxButtons.YesNo);

            if (result2 == DialogResult.Yes)
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string filename = save.FileName;
                    string[] temp2 = { "Right triangle: ", textBox_a.Text, textBox_b.Text, textBox_c.Text, textBox_right.Text + "\n" };

                    System.IO.File.AppendAllLines(filename, temp2);
                    MessageBox.Show("Файл сохранен");
                }
            }
            Application.Exit();
        }
        private void OpenFileButton2_Click(object sender, EventArgs e)
        {
            open.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            if (open.ShowDialog() == DialogResult.OK)
            {
                string filename = open.FileName;

                textBox_a.Text = System.IO.File.ReadLines(filename).Skip(12).FirstOrDefault();
                textBox_b.Text = System.IO.File.ReadLines(filename).Skip(13).FirstOrDefault();
                textBox_c.Text = System.IO.File.ReadLines(filename).Skip(14).FirstOrDefault();
            }
        }
    }
}
