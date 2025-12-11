namespace Tyuiu.KomkovAA.Sprint6.Task4.V25
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
            textBoxRes = new TextBox();
            textBoxStart = new TextBox();
            textBoxStop = new TextBox();
            buttonRes = new Button();
            buttonFile = new Button();
            buttonHelp = new Button();
            SuspendLayout();
            // 
            // textBoxRes
            // 
            textBoxRes.Location = new Point(41, 33);
            textBoxRes.Multiline = true;
            textBoxRes.Name = "textBoxRes";
            textBoxRes.ReadOnly = true;
            textBoxRes.Size = new Size(210, 340);
            textBoxRes.TabIndex = 0;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(419, 21);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(125, 27);
            textBoxStart.TabIndex = 1;
            textBoxStart.Text = "-5";
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(419, 73);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(125, 27);
            textBoxStop.TabIndex = 2;
            textBoxStop.Text = "5";
            // 
            // buttonRes
            // 
            buttonRes.Location = new Point(563, 203);
            buttonRes.Name = "buttonRes";
            buttonRes.Size = new Size(94, 29);
            buttonRes.TabIndex = 3;
            buttonRes.Text = "button1";
            buttonRes.UseVisualStyleBackColor = true;
            buttonRes.Click += buttonRes_Click;
            // 
            // buttonFile
            // 
            buttonFile.Location = new Point(563, 261);
            buttonFile.Name = "buttonFile";
            buttonFile.Size = new Size(94, 29);
            buttonFile.TabIndex = 4;
            buttonFile.Text = "button2";
            buttonFile.UseVisualStyleBackColor = true;
            buttonFile.Click += buttonFile_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(563, 325);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(94, 29);
            buttonHelp.TabIndex = 5;
            buttonHelp.Text = "button3";
            buttonHelp.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp);
            Controls.Add(buttonFile);
            Controls.Add(buttonRes);
            Controls.Add(textBoxStop);
            Controls.Add(textBoxStart);
            Controls.Add(textBoxRes);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxRes;
        private TextBox textBoxStart;
        private TextBox textBoxStop;
        private Button buttonRes;
        private Button buttonFile;
        private Button buttonHelp;
    }
}
