namespace Tyuiu.KomkovAA.Sprint6.Task6.V14
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonFile = new Button();
            buttonRes = new Button();
            buttonHelp = new Button();
            textBoxIn = new TextBox();
            textBoxRes = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // buttonFile
            // 
            buttonFile.Image = (Image)resources.GetObject("buttonFile.Image");
            buttonFile.Location = new Point(37, 26);
            buttonFile.Name = "buttonFile";
            buttonFile.Size = new Size(98, 53);
            buttonFile.TabIndex = 0;
            toolTip1.SetToolTip(buttonFile, "Загрузить файл");
            buttonFile.UseVisualStyleBackColor = true;
            buttonFile.Click += buttonFile_Click;
            // 
            // buttonRes
            // 
            buttonRes.Location = new Point(141, 26);
            buttonRes.Name = "buttonRes";
            buttonRes.Size = new Size(94, 29);
            buttonRes.TabIndex = 1;
            buttonRes.Text = "button2";
            toolTip1.SetToolTip(buttonRes, "Кнопка выполнения задачи");
            buttonRes.UseVisualStyleBackColor = true;
            buttonRes.Click += buttonRes_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(675, 26);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(94, 29);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "button3";
            toolTip1.SetToolTip(buttonHelp, "Информация о разработчике ");
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // textBoxIn
            // 
            textBoxIn.Location = new Point(37, 85);
            textBoxIn.Multiline = true;
            textBoxIn.Name = "textBoxIn";
            textBoxIn.Size = new Size(342, 353);
            textBoxIn.TabIndex = 3;
            // 
            // textBoxRes
            // 
            textBoxRes.Location = new Point(427, 85);
            textBoxRes.Multiline = true;
            textBoxRes.Name = "textBoxRes";
            textBoxRes.Size = new Size(342, 353);
            textBoxRes.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxRes);
            Controls.Add(textBoxIn);
            Controls.Add(buttonHelp);
            Controls.Add(buttonRes);
            Controls.Add(buttonFile);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonFile;
        private Button buttonRes;
        private Button buttonHelp;
        private TextBox textBoxIn;
        private TextBox textBoxRes;
        private ToolTip toolTip1;
        private OpenFileDialog openFileDialog1;
    }
}
