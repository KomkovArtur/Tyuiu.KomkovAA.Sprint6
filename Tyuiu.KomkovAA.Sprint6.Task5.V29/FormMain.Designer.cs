namespace Tyuiu.KomkovAA.Sprint6.Task5.V29
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            dataGridViewRes = new DataGridView();
            num = new DataGridViewTextBoxColumn();
            Res = new DataGridViewTextBoxColumn();
            buttonRes = new Button();
            buttonFile = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRes
            // 
            dataGridViewRes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes.ColumnHeadersVisible = false;
            dataGridViewRes.Columns.AddRange(new DataGridViewColumn[] { num, Res });
            dataGridViewRes.Location = new Point(66, 61);
            dataGridViewRes.Name = "dataGridViewRes";
            dataGridViewRes.RowHeadersVisible = false;
            dataGridViewRes.RowHeadersWidth = 51;
            dataGridViewRes.Size = new Size(300, 188);
            dataGridViewRes.TabIndex = 0;
            // 
            // num
            // 
            num.HeaderText = "Column1";
            num.MinimumWidth = 6;
            num.Name = "num";
            num.Width = 125;
            // 
            // Res
            // 
            Res.HeaderText = "Column1";
            Res.MinimumWidth = 6;
            Res.Name = "Res";
            Res.Width = 125;
            // 
            // buttonRes
            // 
            buttonRes.Image = (Image)resources.GetObject("buttonRes.Image");
            buttonRes.Location = new Point(608, 138);
            buttonRes.Name = "buttonRes";
            buttonRes.Size = new Size(115, 45);
            buttonRes.TabIndex = 1;
            buttonRes.Text = "button1";
            buttonRes.UseVisualStyleBackColor = true;
            buttonRes.Click += buttonRes_Click;
            // 
            // buttonFile
            // 
            buttonFile.Location = new Point(608, 238);
            buttonFile.Name = "buttonFile";
            buttonFile.Size = new Size(94, 29);
            buttonFile.TabIndex = 2;
            buttonFile.Text = "button2";
            buttonFile.UseVisualStyleBackColor = true;
            buttonFile.Click += buttonFile_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonFile);
            Controls.Add(buttonRes);
            Controls.Add(dataGridViewRes);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewRes;
        private DataGridViewTextBoxColumn num;
        private DataGridViewTextBoxColumn Res;
        private Button buttonRes;
        private Button buttonFile;
    }
}
