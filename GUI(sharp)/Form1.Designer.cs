namespace GUI_sharp_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExitButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.side_value_a = new System.Windows.Forms.Label();
            this.side_value_b = new System.Windows.Forms.Label();
            this.side_value_c = new System.Windows.Forms.Label();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.textBox_c = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.isExistsButton = new System.Windows.Forms.Button();
            this.PerimeterButton = new System.Windows.Forms.Button();
            this.SquareButton = new System.Windows.Forms.Button();
            this.textBox_isExists = new System.Windows.Forms.TextBox();
            this.textBox_Square = new System.Windows.Forms.TextBox();
            this.label_Square = new System.Windows.Forms.Label();
            this.textBox_Perimeter = new System.Windows.Forms.TextBox();
            this.label_Perimeter = new System.Windows.Forms.Label();
            this.AngleButton = new System.Windows.Forms.Button();
            this.textBox_Angle1 = new System.Windows.Forms.TextBox();
            this.textBox_Angle3 = new System.Windows.Forms.TextBox();
            this.textBox_Angle2 = new System.Windows.Forms.TextBox();
            this.label_Angle1 = new System.Windows.Forms.Label();
            this.label_Angle2 = new System.Windows.Forms.Label();
            this.label_Angle3 = new System.Windows.Forms.Label();
            this.TransitionButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Location = new System.Drawing.Point(46, 380);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(130, 46);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(28, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(164, 50);
            this.title.TabIndex = 1;
            this.title.Text = "Введите стороны \r\n  треугольника";
            // 
            // textBox_a
            // 
            this.textBox_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_a.Location = new System.Drawing.Point(90, 73);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(86, 26);
            this.textBox_a.TabIndex = 2;
            // 
            // side_value_a
            // 
            this.side_value_a.AutoSize = true;
            this.side_value_a.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.side_value_a.Location = new System.Drawing.Point(29, 65);
            this.side_value_a.Name = "side_value_a";
            this.side_value_a.Size = new System.Drawing.Size(55, 35);
            this.side_value_a.TabIndex = 3;
            this.side_value_a.Text = "а =";
            // 
            // side_value_b
            // 
            this.side_value_b.AutoSize = true;
            this.side_value_b.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.side_value_b.Location = new System.Drawing.Point(27, 111);
            this.side_value_b.Name = "side_value_b";
            this.side_value_b.Size = new System.Drawing.Size(67, 35);
            this.side_value_b.TabIndex = 4;
            this.side_value_b.Text = "b = ";
            // 
            // side_value_c
            // 
            this.side_value_c.AutoSize = true;
            this.side_value_c.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.side_value_c.Location = new System.Drawing.Point(29, 161);
            this.side_value_c.Name = "side_value_c";
            this.side_value_c.Size = new System.Drawing.Size(65, 35);
            this.side_value_c.TabIndex = 5;
            this.side_value_c.Text = "c = ";
            // 
            // textBox_b
            // 
            this.textBox_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_b.Location = new System.Drawing.Point(90, 119);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(86, 26);
            this.textBox_b.TabIndex = 6;
            // 
            // textBox_c
            // 
            this.textBox_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_c.Location = new System.Drawing.Point(90, 169);
            this.textBox_c.Name = "textBox_c";
            this.textBox_c.Size = new System.Drawing.Size(86, 26);
            this.textBox_c.TabIndex = 7;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.Location = new System.Drawing.Point(60, 222);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(116, 39);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // isExistsButton
            // 
            this.isExistsButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.isExistsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.isExistsButton.Location = new System.Drawing.Point(333, 12);
            this.isExistsButton.Name = "isExistsButton";
            this.isExistsButton.Size = new System.Drawing.Size(221, 56);
            this.isExistsButton.TabIndex = 9;
            this.isExistsButton.Text = "Проверка, существует ли треугольник";
            this.isExistsButton.UseVisualStyleBackColor = false;
            this.isExistsButton.Click += new System.EventHandler(this.isExistsButton_Click);
            // 
            // PerimeterButton
            // 
            this.PerimeterButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.PerimeterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PerimeterButton.Location = new System.Drawing.Point(371, 270);
            this.PerimeterButton.Name = "PerimeterButton";
            this.PerimeterButton.Size = new System.Drawing.Size(155, 46);
            this.PerimeterButton.TabIndex = 10;
            this.PerimeterButton.Text = "Найти периметр ";
            this.PerimeterButton.UseVisualStyleBackColor = false;
            this.PerimeterButton.Click += new System.EventHandler(this.PerimeterButton_Click);
            // 
            // SquareButton
            // 
            this.SquareButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.SquareButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SquareButton.Location = new System.Drawing.Point(371, 146);
            this.SquareButton.Name = "SquareButton";
            this.SquareButton.Size = new System.Drawing.Size(156, 49);
            this.SquareButton.TabIndex = 11;
            this.SquareButton.Text = "Найти площадь";
            this.SquareButton.UseVisualStyleBackColor = false;
            this.SquareButton.Click += new System.EventHandler(this.SquareButton_Click);
            // 
            // textBox_isExists
            // 
            this.textBox_isExists.Location = new System.Drawing.Point(333, 93);
            this.textBox_isExists.Name = "textBox_isExists";
            this.textBox_isExists.Size = new System.Drawing.Size(221, 22);
            this.textBox_isExists.TabIndex = 12;
            // 
            // textBox_Square
            // 
            this.textBox_Square.Location = new System.Drawing.Point(440, 222);
            this.textBox_Square.Name = "textBox_Square";
            this.textBox_Square.Size = new System.Drawing.Size(83, 22);
            this.textBox_Square.TabIndex = 13;
            // 
            // label_Square
            // 
            this.label_Square.AutoSize = true;
            this.label_Square.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Square.Location = new System.Drawing.Point(386, 222);
            this.label_Square.Name = "label_Square";
            this.label_Square.Size = new System.Drawing.Size(48, 25);
            this.label_Square.TabIndex = 14;
            this.label_Square.Text = "S = ";
            // 
            // textBox_Perimeter
            // 
            this.textBox_Perimeter.Location = new System.Drawing.Point(440, 341);
            this.textBox_Perimeter.Name = "textBox_Perimeter";
            this.textBox_Perimeter.Size = new System.Drawing.Size(82, 22);
            this.textBox_Perimeter.TabIndex = 15;
            // 
            // label_Perimeter
            // 
            this.label_Perimeter.AutoSize = true;
            this.label_Perimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Perimeter.Location = new System.Drawing.Point(386, 337);
            this.label_Perimeter.Name = "label_Perimeter";
            this.label_Perimeter.Size = new System.Drawing.Size(47, 25);
            this.label_Perimeter.TabIndex = 16;
            this.label_Perimeter.Text = "P = ";
            // 
            // AngleButton
            // 
            this.AngleButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.AngleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AngleButton.Location = new System.Drawing.Point(689, 93);
            this.AngleButton.Name = "AngleButton";
            this.AngleButton.Size = new System.Drawing.Size(162, 52);
            this.AngleButton.TabIndex = 17;
            this.AngleButton.Text = "Найти углы";
            this.AngleButton.UseVisualStyleBackColor = false;
            this.AngleButton.Click += new System.EventHandler(this.AngleButton_Click);
            // 
            // textBox_Angle1
            // 
            this.textBox_Angle1.Location = new System.Drawing.Point(735, 175);
            this.textBox_Angle1.Name = "textBox_Angle1";
            this.textBox_Angle1.Size = new System.Drawing.Size(116, 22);
            this.textBox_Angle1.TabIndex = 18;
            // 
            // textBox_Angle3
            // 
            this.textBox_Angle3.Location = new System.Drawing.Point(735, 261);
            this.textBox_Angle3.Name = "textBox_Angle3";
            this.textBox_Angle3.Size = new System.Drawing.Size(116, 22);
            this.textBox_Angle3.TabIndex = 19;
            // 
            // textBox_Angle2
            // 
            this.textBox_Angle2.Location = new System.Drawing.Point(735, 218);
            this.textBox_Angle2.Name = "textBox_Angle2";
            this.textBox_Angle2.Size = new System.Drawing.Size(116, 22);
            this.textBox_Angle2.TabIndex = 20;
            // 
            // label_Angle1
            // 
            this.label_Angle1.AutoSize = true;
            this.label_Angle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Angle1.Location = new System.Drawing.Point(684, 171);
            this.label_Angle1.Name = "label_Angle1";
            this.label_Angle1.Size = new System.Drawing.Size(48, 25);
            this.label_Angle1.TabIndex = 21;
            this.label_Angle1.Text = "A = ";
            // 
            // label_Angle2
            // 
            this.label_Angle2.AutoSize = true;
            this.label_Angle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Angle2.Location = new System.Drawing.Point(685, 214);
            this.label_Angle2.Name = "label_Angle2";
            this.label_Angle2.Size = new System.Drawing.Size(47, 25);
            this.label_Angle2.TabIndex = 22;
            this.label_Angle2.Text = "B = ";
            // 
            // label_Angle3
            // 
            this.label_Angle3.AutoSize = true;
            this.label_Angle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Angle3.Location = new System.Drawing.Point(685, 257);
            this.label_Angle3.Name = "label_Angle3";
            this.label_Angle3.Size = new System.Drawing.Size(49, 25);
            this.label_Angle3.TabIndex = 23;
            this.label_Angle3.Text = "C = ";
            // 
            // TransitionButton1
            // 
            this.TransitionButton1.BackColor = System.Drawing.Color.SlateBlue;
            this.TransitionButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransitionButton1.Location = new System.Drawing.Point(678, 380);
            this.TransitionButton1.Name = "TransitionButton1";
            this.TransitionButton1.Size = new System.Drawing.Size(139, 46);
            this.TransitionButton1.TabIndex = 24;
            this.TransitionButton1.Text = "Далее";
            this.TransitionButton1.UseVisualStyleBackColor = false;
            this.TransitionButton1.Click += new System.EventHandler(this.TransitionButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(895, 450);
            this.Controls.Add(this.TransitionButton1);
            this.Controls.Add(this.label_Angle3);
            this.Controls.Add(this.label_Angle2);
            this.Controls.Add(this.label_Angle1);
            this.Controls.Add(this.textBox_Angle2);
            this.Controls.Add(this.textBox_Angle3);
            this.Controls.Add(this.textBox_Angle1);
            this.Controls.Add(this.AngleButton);
            this.Controls.Add(this.label_Perimeter);
            this.Controls.Add(this.textBox_Perimeter);
            this.Controls.Add(this.label_Square);
            this.Controls.Add(this.textBox_Square);
            this.Controls.Add(this.textBox_isExists);
            this.Controls.Add(this.SquareButton);
            this.Controls.Add(this.PerimeterButton);
            this.Controls.Add(this.isExistsButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.textBox_c);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.side_value_c);
            this.Controls.Add(this.side_value_b);
            this.Controls.Add(this.side_value_a);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.title);
            this.Controls.Add(this.ExitButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.Label side_value_a;
        private System.Windows.Forms.Label side_value_b;
        private System.Windows.Forms.Label side_value_c;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.TextBox textBox_c;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button isExistsButton;
        private System.Windows.Forms.Button PerimeterButton;
        private System.Windows.Forms.Button SquareButton;
        private System.Windows.Forms.TextBox textBox_isExists;
        private System.Windows.Forms.TextBox textBox_Square;
        private System.Windows.Forms.Label label_Square;
        private System.Windows.Forms.TextBox textBox_Perimeter;
        private System.Windows.Forms.Label label_Perimeter;
        private System.Windows.Forms.Button AngleButton;
        private System.Windows.Forms.TextBox textBox_Angle1;
        private System.Windows.Forms.TextBox textBox_Angle3;
        private System.Windows.Forms.TextBox textBox_Angle2;
        private System.Windows.Forms.Label label_Angle1;
        private System.Windows.Forms.Label label_Angle2;
        private System.Windows.Forms.Label label_Angle3;
        private System.Windows.Forms.Button TransitionButton1;
    }
}

