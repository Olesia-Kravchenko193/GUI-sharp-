namespace GUI_sharp_
{
    partial class Form3
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
            this.Quantity_N_label = new System.Windows.Forms.Label();
            this.Quantity_M_label = new System.Windows.Forms.Label();
            this.textBox_Quantity_N = new System.Windows.Forms.TextBox();
            this.textBox_Quantity_M = new System.Windows.Forms.TextBox();
            this.textBox_infoN = new System.Windows.Forms.TextBox();
            this.textBox_infoM = new System.Windows.Forms.TextBox();
            this.ExitButton3 = new System.Windows.Forms.Button();
            this.textBox_minGipotenus = new System.Windows.Forms.TextBox();
            this.textBox_maxS = new System.Windows.Forms.TextBox();
            this.InitButton = new System.Windows.Forms.Button();
            this.label_MAX_S = new System.Windows.Forms.Label();
            this.label_MIN_Hipotenus = new System.Windows.Forms.Label();
            this.labelMAX_number = new System.Windows.Forms.Label();
            this.labelMIN_number = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Quantity_N_label
            // 
            this.Quantity_N_label.AutoSize = true;
            this.Quantity_N_label.Location = new System.Drawing.Point(39, 33);
            this.Quantity_N_label.Name = "Quantity_N_label";
            this.Quantity_N_label.Size = new System.Drawing.Size(224, 17);
            this.Quantity_N_label.TabIndex = 0;
            this.Quantity_N_label.Text = "Введите кол-во N треугольников";
            // 
            // Quantity_M_label
            // 
            this.Quantity_M_label.AutoSize = true;
            this.Quantity_M_label.Location = new System.Drawing.Point(335, 33);
            this.Quantity_M_label.Name = "Quantity_M_label";
            this.Quantity_M_label.Size = new System.Drawing.Size(329, 17);
            this.Quantity_M_label.TabIndex = 1;
            this.Quantity_M_label.Text = "Введите кол-во М прямоугольных треугольников";
            // 
            // textBox_Quantity_N
            // 
            this.textBox_Quantity_N.Location = new System.Drawing.Point(98, 82);
            this.textBox_Quantity_N.Name = "textBox_Quantity_N";
            this.textBox_Quantity_N.Size = new System.Drawing.Size(100, 22);
            this.textBox_Quantity_N.TabIndex = 2;
            // 
            // textBox_Quantity_M
            // 
            this.textBox_Quantity_M.Location = new System.Drawing.Point(443, 82);
            this.textBox_Quantity_M.Name = "textBox_Quantity_M";
            this.textBox_Quantity_M.Size = new System.Drawing.Size(100, 22);
            this.textBox_Quantity_M.TabIndex = 3;
            // 
            // textBox_infoN
            // 
            this.textBox_infoN.Location = new System.Drawing.Point(42, 143);
            this.textBox_infoN.Multiline = true;
            this.textBox_infoN.Name = "textBox_infoN";
            this.textBox_infoN.Size = new System.Drawing.Size(221, 152);
            this.textBox_infoN.TabIndex = 4;
            // 
            // textBox_infoM
            // 
            this.textBox_infoM.Location = new System.Drawing.Point(354, 141);
            this.textBox_infoM.Multiline = true;
            this.textBox_infoM.Name = "textBox_infoM";
            this.textBox_infoM.Size = new System.Drawing.Size(285, 152);
            this.textBox_infoM.TabIndex = 5;
            // 
            // ExitButton3
            // 
            this.ExitButton3.BackColor = System.Drawing.Color.Red;
            this.ExitButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton3.Location = new System.Drawing.Point(643, 381);
            this.ExitButton3.Name = "ExitButton3";
            this.ExitButton3.Size = new System.Drawing.Size(119, 34);
            this.ExitButton3.TabIndex = 8;
            this.ExitButton3.Text = "Exit";
            this.ExitButton3.UseVisualStyleBackColor = false;
            this.ExitButton3.Click += new System.EventHandler(this.ExitButton3_Click);
            // 
            // textBox_minGipotenus
            // 
            this.textBox_minGipotenus.Location = new System.Drawing.Point(382, 381);
            this.textBox_minGipotenus.Name = "textBox_minGipotenus";
            this.textBox_minGipotenus.Size = new System.Drawing.Size(221, 22);
            this.textBox_minGipotenus.TabIndex = 9;
            // 
            // textBox_maxS
            // 
            this.textBox_maxS.Location = new System.Drawing.Point(59, 381);
            this.textBox_maxS.Name = "textBox_maxS";
            this.textBox_maxS.Size = new System.Drawing.Size(189, 22);
            this.textBox_maxS.TabIndex = 10;
            // 
            // InitButton
            // 
            this.InitButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.InitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InitButton.Location = new System.Drawing.Point(672, 190);
            this.InitButton.Name = "InitButton";
            this.InitButton.Size = new System.Drawing.Size(70, 60);
            this.InitButton.TabIndex = 11;
            this.InitButton.Text = "init";
            this.InitButton.UseVisualStyleBackColor = false;
            this.InitButton.Click += new System.EventHandler(this.InitButton_Click);
            // 
            // label_MAX_S
            // 
            this.label_MAX_S.AutoSize = true;
            this.label_MAX_S.Location = new System.Drawing.Point(12, 347);
            this.label_MAX_S.Name = "label_MAX_S";
            this.label_MAX_S.Size = new System.Drawing.Size(250, 17);
            this.label_MAX_S.TabIndex = 12;
            this.label_MAX_S.Text = "MAX площадь имеет треугольник № ";
            // 
            // label_MIN_Hipotenus
            // 
            this.label_MIN_Hipotenus.AutoSize = true;
            this.label_MIN_Hipotenus.Location = new System.Drawing.Point(317, 347);
            this.label_MIN_Hipotenus.Name = "label_MIN_Hipotenus";
            this.label_MIN_Hipotenus.Size = new System.Drawing.Size(322, 17);
            this.label_MIN_Hipotenus.TabIndex = 13;
            this.label_MIN_Hipotenus.Text = "Найменьшую гипотинузу имеет треугольник № ";
            // 
            // labelMAX_number
            // 
            this.labelMAX_number.AutoSize = true;
            this.labelMAX_number.Location = new System.Drawing.Point(268, 347);
            this.labelMAX_number.Name = "labelMAX_number";
            this.labelMAX_number.Size = new System.Drawing.Size(20, 17);
            this.labelMAX_number.TabIndex = 14;
            this.labelMAX_number.Text = "...";
            // 
            // labelMIN_number
            // 
            this.labelMIN_number.AutoSize = true;
            this.labelMIN_number.Location = new System.Drawing.Point(640, 347);
            this.labelMIN_number.Name = "labelMIN_number";
            this.labelMIN_number.Size = new System.Drawing.Size(20, 17);
            this.labelMIN_number.TabIndex = 15;
            this.labelMIN_number.Text = "...";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMIN_number);
            this.Controls.Add(this.labelMAX_number);
            this.Controls.Add(this.label_MIN_Hipotenus);
            this.Controls.Add(this.label_MAX_S);
            this.Controls.Add(this.InitButton);
            this.Controls.Add(this.textBox_maxS);
            this.Controls.Add(this.textBox_minGipotenus);
            this.Controls.Add(this.ExitButton3);
            this.Controls.Add(this.textBox_infoM);
            this.Controls.Add(this.textBox_infoN);
            this.Controls.Add(this.textBox_Quantity_M);
            this.Controls.Add(this.textBox_Quantity_N);
            this.Controls.Add(this.Quantity_M_label);
            this.Controls.Add(this.Quantity_N_label);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Quantity_N_label;
        private System.Windows.Forms.Label Quantity_M_label;
        private System.Windows.Forms.TextBox textBox_Quantity_N;
        private System.Windows.Forms.TextBox textBox_Quantity_M;
        private System.Windows.Forms.TextBox textBox_infoN;
        private System.Windows.Forms.TextBox textBox_infoM;
        private System.Windows.Forms.Button ExitButton3;
        private System.Windows.Forms.TextBox textBox_minGipotenus;
        private System.Windows.Forms.TextBox textBox_maxS;
        private System.Windows.Forms.Button InitButton;
        private System.Windows.Forms.Label label_MAX_S;
        private System.Windows.Forms.Label label_MIN_Hipotenus;
        private System.Windows.Forms.Label labelMAX_number;
        private System.Windows.Forms.Label labelMIN_number;
    }
}