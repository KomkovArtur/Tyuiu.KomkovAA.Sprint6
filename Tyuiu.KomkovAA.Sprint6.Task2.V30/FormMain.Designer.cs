namespace Tyuiu.KomkovAA.Sprint6.Task2.V30
{
    partial class Form1
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
            textBoxStart = new TextBox();
            textBoxStop = new TextBox();
            dataGridViewRes = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Res = new DataGridViewTextBoxColumn();
            buttonRes = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes).BeginInit();
            SuspendLayout();
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(91, 207);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(125, 27);
            textBoxStart.TabIndex = 0;
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(96, 289);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(125, 27);
            textBoxStop.TabIndex = 1;
            // 
            // dataGridViewRes
            // 
            dataGridViewRes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes.Columns.AddRange(new DataGridViewColumn[] { X, Res });
            dataGridViewRes.Location = new Point(451, 33);
            dataGridViewRes.Name = "dataGridViewRes";
            dataGridViewRes.RowHeadersVisible = false;
            dataGridViewRes.RowHeadersWidth = 51;
            dataGridViewRes.Size = new Size(300, 188);
            dataGridViewRes.TabIndex = 2;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 125;
            // 
            // Res
            // 
            Res.HeaderText = "F(X)";
            Res.MinimumWidth = 6;
            Res.Name = "Res";
            Res.Width = 125;
            // 
            // buttonRes
            // 
            buttonRes.Location = new Point(399, 317);
            buttonRes.Name = "buttonRes";
            buttonRes.Size = new Size(94, 29);
            buttonRes.TabIndex = 3;
            buttonRes.Text = "button1";
            buttonRes.UseVisualStyleBackColor = true;
            buttonRes.Click += buttonRes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRes);
            Controls.Add(dataGridViewRes);
            Controls.Add(textBoxStop);
            Controls.Add(textBoxStart);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxStart;
        private TextBox textBoxStop;
        private DataGridView dataGridViewRes;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Res;
        private Button buttonRes;
    }
}
