namespace Tyuiu.KomkovAA.Sprint6.Task1.V24
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
            buttonRes = new Button();
            buttonHelp = new Button();
            textBoxStart = new TextBox();
            textBoxStop = new TextBox();
            SuspendLayout();
            // 
            // textBoxRes
            // 
            textBoxRes.Location = new Point(540, 38);
            textBoxRes.Multiline = true;
            textBoxRes.Name = "textBoxRes";
            textBoxRes.ScrollBars = ScrollBars.Vertical;
            textBoxRes.Size = new Size(248, 349);
            textBoxRes.TabIndex = 0;
            // 
            // buttonRes
            // 
            buttonRes.Location = new Point(385, 334);
            buttonRes.Name = "buttonRes";
            buttonRes.Size = new Size(94, 29);
            buttonRes.TabIndex = 1;
            buttonRes.Text = "button1";
            buttonRes.UseVisualStyleBackColor = true;
            buttonRes.Click += buttonRes_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(242, 334);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(94, 29);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "button2";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(59, 230);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(125, 27);
            textBoxStart.TabIndex = 3;
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(242, 230);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(125, 27);
            textBoxStop.TabIndex = 4;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxStop);
            Controls.Add(textBoxStart);
            Controls.Add(buttonHelp);
            Controls.Add(buttonRes);
            Controls.Add(textBoxRes);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxRes;
        private Button buttonRes;
        private Button buttonHelp;
        private TextBox textBoxStart;
        private TextBox textBoxStop;
    }
}
