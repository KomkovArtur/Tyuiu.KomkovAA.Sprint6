namespace Tyuiu.KomkovAA.Sprint6.Task7.V21
{
    partial class FormAbout
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(187, 20);
            label1.TabIndex = 0;
            label1.Text = "Разработчик:  Комков.А.А";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 29);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 1;
            label2.Text = "Группа:  Рппб-25-1";
            // 
            // label3
            // 
            label3.Location = new Point(120, 49);
            label3.Name = "label3";
            label3.Size = new Size(250, 64);
            label3.TabIndex = 2;
            label3.Text = "Программа была разработана в рамках изучения языка C#";
            // 
            // label4
            // 
            label4.Location = new Point(10, 113);
            label4.Name = "label4";
            label4.Size = new Size(359, 31);
            label4.TabIndex = 3;
            label4.Text = "Тюменский индустриальный университет (с) 2025";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 135);
            label5.Name = "label5";
            label5.Size = new Size(329, 20);
            label5.TabIndex = 4;
            label5.Text = "Высшая школа цифровых технологий (с) 2025";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 174);
            label6.Name = "label6";
            label6.Size = new Size(357, 20);
            label6.TabIndex = 5;
            label6.Text = "Внутреннее имя: Tyuiu.KomkovAA.Sprint6.Task7.V21";
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 203);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}