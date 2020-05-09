namespace GUI_sharp_
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExitButton2 = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveButton2 = new System.Windows.Forms.Button();
            this.textBox_right = new System.Windows.Forms.TextBox();
            this.TransitionButton2 = new System.Windows.Forms.Button();
            this.textBox_c = new System.Windows.Forms.TextBox();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.side_value_c = new System.Windows.Forms.Label();
            this.side_value_b = new System.Windows.Forms.Label();
            this.side_value_a = new System.Windows.Forms.Label();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.backButton1 = new System.Windows.Forms.Button();
            this.OpenFileButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitButton2
            // 
            this.ExitButton2.BackColor = System.Drawing.Color.Red;
            this.ExitButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton2.Location = new System.Drawing.Point(83, 365);
            this.ExitButton2.Name = "ExitButton2";
            this.ExitButton2.Size = new System.Drawing.Size(117, 37);
            this.ExitButton2.TabIndex = 0;
            this.ExitButton2.Text = "Exit";
            this.ExitButton2.UseVisualStyleBackColor = false;
            this.ExitButton2.Click += new System.EventHandler(this.ExitButton2_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(318, 78);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(275, 25);
            this.title.TabIndex = 8;
            this.title.Text = "Введите стороны треугольника";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(193, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Проверка, является ли треугольник прямоугольным";
            // 
            // SaveButton2
            // 
            this.SaveButton2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SaveButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton2.Location = new System.Drawing.Point(407, 190);
            this.SaveButton2.Name = "SaveButton2";
            this.SaveButton2.Size = new System.Drawing.Size(117, 37);
            this.SaveButton2.TabIndex = 16;
            this.SaveButton2.Text = "Save";
            this.SaveButton2.UseVisualStyleBackColor = false;
            this.SaveButton2.Click += new System.EventHandler(this.SaveButton2_Click);
            // 
            // textBox_right
            // 
            this.textBox_right.Location = new System.Drawing.Point(310, 258);
            this.textBox_right.Name = "textBox_right";
            this.textBox_right.Size = new System.Drawing.Size(305, 22);
            this.textBox_right.TabIndex = 17;
            // 
            // TransitionButton2
            // 
            this.TransitionButton2.BackColor = System.Drawing.Color.SlateBlue;
            this.TransitionButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransitionButton2.Location = new System.Drawing.Point(700, 387);
            this.TransitionButton2.Name = "TransitionButton2";
            this.TransitionButton2.Size = new System.Drawing.Size(129, 39);
            this.TransitionButton2.TabIndex = 18;
            this.TransitionButton2.Text = "Далее";
            this.TransitionButton2.UseVisualStyleBackColor = false;
            this.TransitionButton2.Click += new System.EventHandler(this.TransitionButton2_Click);
            // 
            // textBox_c
            // 
            this.textBox_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_c.Location = new System.Drawing.Point(675, 130);
            this.textBox_c.Name = "textBox_c";
            this.textBox_c.Size = new System.Drawing.Size(86, 26);
            this.textBox_c.TabIndex = 24;
            // 
            // textBox_b
            // 
            this.textBox_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_b.Location = new System.Drawing.Point(449, 130);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(86, 26);
            this.textBox_b.TabIndex = 23;
            // 
            // side_value_c
            // 
            this.side_value_c.AutoSize = true;
            this.side_value_c.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.side_value_c.Location = new System.Drawing.Point(604, 122);
            this.side_value_c.Name = "side_value_c";
            this.side_value_c.Size = new System.Drawing.Size(65, 35);
            this.side_value_c.TabIndex = 22;
            this.side_value_c.Text = "c = ";
            // 
            // side_value_b
            // 
            this.side_value_b.AutoSize = true;
            this.side_value_b.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.side_value_b.Location = new System.Drawing.Point(376, 122);
            this.side_value_b.Name = "side_value_b";
            this.side_value_b.Size = new System.Drawing.Size(67, 35);
            this.side_value_b.TabIndex = 21;
            this.side_value_b.Text = "b = ";
            // 
            // side_value_a
            // 
            this.side_value_a.AutoSize = true;
            this.side_value_a.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.side_value_a.Location = new System.Drawing.Point(162, 122);
            this.side_value_a.Name = "side_value_a";
            this.side_value_a.Size = new System.Drawing.Size(55, 35);
            this.side_value_a.TabIndex = 20;
            this.side_value_a.Text = "а =";
            // 
            // textBox_a
            // 
            this.textBox_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_a.Location = new System.Drawing.Point(223, 130);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(86, 26);
            this.textBox_a.TabIndex = 19;
            // 
            // backButton1
            // 
            this.backButton1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.backButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton1.Location = new System.Drawing.Point(700, 331);
            this.backButton1.Name = "backButton1";
            this.backButton1.Size = new System.Drawing.Size(129, 38);
            this.backButton1.TabIndex = 25;
            this.backButton1.Text = "Назад";
            this.backButton1.UseVisualStyleBackColor = false;
            this.backButton1.Click += new System.EventHandler(this.backButton1_Click);
            // 
            // OpenFileButton2
            // 
            this.OpenFileButton2.Location = new System.Drawing.Point(403, 302);
            this.OpenFileButton2.Name = "OpenFileButton2";
            this.OpenFileButton2.Size = new System.Drawing.Size(121, 54);
            this.OpenFileButton2.TabIndex = 28;
            this.OpenFileButton2.Text = "Open file";
            this.OpenFileButton2.UseVisualStyleBackColor = true;
            this.OpenFileButton2.Click += new System.EventHandler(this.OpenFileButton2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(895, 450);
            this.Controls.Add(this.OpenFileButton2);
            this.Controls.Add(this.backButton1);
            this.Controls.Add(this.textBox_c);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.side_value_c);
            this.Controls.Add(this.side_value_b);
            this.Controls.Add(this.side_value_a);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.TransitionButton2);
            this.Controls.Add(this.textBox_right);
            this.Controls.Add(this.SaveButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.ExitButton2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveButton2;
        private System.Windows.Forms.TextBox textBox_right;
        private System.Windows.Forms.Button TransitionButton2;
        private System.Windows.Forms.TextBox textBox_c;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.Label side_value_c;
        private System.Windows.Forms.Label side_value_b;
        private System.Windows.Forms.Label side_value_a;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.Button backButton1;
        private System.Windows.Forms.Button OpenFileButton2;
    }
}