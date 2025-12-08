namespace Tyuiu.KomkovAA.Sprint6.Task0.V1
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
            buttonRes = new Button();
            buttonHelp = new Button();
            textBoxRes = new TextBox();
            textBoxInput = new TextBox();
            SuspendLayout();
            // 
            // buttonRes
            // 
            buttonRes.Location = new Point(562, 347);
            buttonRes.Name = "buttonRes";
            buttonRes.Size = new Size(94, 29);
            buttonRes.TabIndex = 0;
            buttonRes.Text = "button1";
            buttonRes.UseVisualStyleBackColor = true;
            buttonRes.Click += buttonRes_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(418, 348);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(94, 29);
            buttonHelp.TabIndex = 1;
            buttonHelp.Text = "button2";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // textBoxRes
            // 
            textBoxRes.Location = new Point(585, 165);
            textBoxRes.Name = "textBoxRes";
            textBoxRes.Size = new Size(125, 27);
            textBoxRes.TabIndex = 2;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(323, 165);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(125, 27);
            textBoxInput.TabIndex = 3;
            textBoxInput.TextChanged += textBoxInput_TextChanged;
            textBoxInput.KeyPress += textBoxInput_KeyPress;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxInput);
            Controls.Add(textBoxRes);
            Controls.Add(buttonHelp);
            Controls.Add(buttonRes);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRes;
        private Button buttonHelp;
        private TextBox textBoxRes;
        private TextBox textBoxInput;
    }
}
