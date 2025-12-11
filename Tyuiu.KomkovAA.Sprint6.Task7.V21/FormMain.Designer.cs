namespace Tyuiu.KomkovAA.Sprint6.Task7.V21
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
            panelTop_KAA = new Panel();
            groupBox1 = new GroupBox();
            label1 = new Label();
            buttonSave_KAA = new Button();
            buttonAbout_KAA = new Button();
            buttonRes_KAA = new Button();
            buttonIn_KAA = new Button();
            panelLeft_Kaa = new Panel();
            groupBoxIn_KAA = new GroupBox();
            dataGridViewIn_Kaa = new DataGridView();
            panelRight_KAA = new Panel();
            groupBoxOut_KAA = new GroupBox();
            dataGridViewOut_KAA = new DataGridView();
            splitter2 = new Splitter();
            splitter3 = new Splitter();
            openFileDialog1 = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            saveFileDialog1 = new SaveFileDialog();
            panelTop_KAA.SuspendLayout();
            groupBox1.SuspendLayout();
            panelLeft_Kaa.SuspendLayout();
            groupBoxIn_KAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_Kaa).BeginInit();
            panelRight_KAA.SuspendLayout();
            groupBoxOut_KAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_KAA).BeginInit();
            SuspendLayout();
            // 
            // panelTop_KAA
            // 
            panelTop_KAA.Controls.Add(groupBox1);
            panelTop_KAA.Controls.Add(buttonSave_KAA);
            panelTop_KAA.Controls.Add(buttonAbout_KAA);
            panelTop_KAA.Controls.Add(buttonRes_KAA);
            panelTop_KAA.Controls.Add(buttonIn_KAA);
            panelTop_KAA.Dock = DockStyle.Top;
            panelTop_KAA.Location = new Point(0, 0);
            panelTop_KAA.Name = "panelTop_KAA";
            panelTop_KAA.Size = new Size(800, 103);
            panelTop_KAA.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(256, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(453, 85);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 7F);
            label1.Location = new Point(8, 22);
            label1.Name = "label1";
            label1.Size = new Size(422, 69);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // buttonSave_KAA
            // 
            buttonSave_KAA.Image = (Image)resources.GetObject("buttonSave_KAA.Image");
            buttonSave_KAA.Location = new Point(173, 12);
            buttonSave_KAA.Name = "buttonSave_KAA";
            buttonSave_KAA.Size = new Size(77, 68);
            buttonSave_KAA.TabIndex = 3;
            toolTip1.SetToolTip(buttonSave_KAA, "Сохранить обработанные данные в файл в формате csv");
            buttonSave_KAA.UseVisualStyleBackColor = true;
            buttonSave_KAA.Click += buttonSave_KAA_Click;
            buttonSave_KAA.MouseEnter += buttonSave_KAA_MouseEnter;
            // 
            // buttonAbout_KAA
            // 
            buttonAbout_KAA.Image = (Image)resources.GetObject("buttonAbout_KAA.Image");
            buttonAbout_KAA.Location = new Point(715, 12);
            buttonAbout_KAA.Name = "buttonAbout_KAA";
            buttonAbout_KAA.Size = new Size(73, 68);
            buttonAbout_KAA.TabIndex = 2;
            buttonAbout_KAA.UseVisualStyleBackColor = true;
            buttonAbout_KAA.Click += buttonAbout_KAA_Click;
            buttonAbout_KAA.MouseEnter += buttonAbout_KAA_MouseEnter;
            // 
            // buttonRes_KAA
            // 
            buttonRes_KAA.Image = (Image)resources.GetObject("buttonRes_KAA.Image");
            buttonRes_KAA.Location = new Point(91, 12);
            buttonRes_KAA.Name = "buttonRes_KAA";
            buttonRes_KAA.Size = new Size(76, 68);
            buttonRes_KAA.TabIndex = 1;
            toolTip1.SetToolTip(buttonRes_KAA, "Выполнить обработку данных");
            buttonRes_KAA.UseVisualStyleBackColor = true;
            buttonRes_KAA.Click += buttonRes_KAA_Click;
            buttonRes_KAA.MouseEnter += buttonRes_KAA_MouseEnter;
            // 
            // buttonIn_KAA
            // 
            buttonIn_KAA.Image = (Image)resources.GetObject("buttonIn_KAA.Image");
            buttonIn_KAA.Location = new Point(12, 12);
            buttonIn_KAA.Name = "buttonIn_KAA";
            buttonIn_KAA.Size = new Size(73, 68);
            buttonIn_KAA.TabIndex = 0;
            toolTip1.SetToolTip(buttonIn_KAA, "Открыть файл для обработки данных в формати csv\r\n");
            buttonIn_KAA.UseVisualStyleBackColor = true;
            buttonIn_KAA.Click += buttonIn_KAA_Click;
            buttonIn_KAA.MouseEnter += buttonIn_KAA_MouseEnter;
            // 
            // panelLeft_Kaa
            // 
            panelLeft_Kaa.Controls.Add(groupBoxIn_KAA);
            panelLeft_Kaa.Dock = DockStyle.Left;
            panelLeft_Kaa.Location = new Point(0, 103);
            panelLeft_Kaa.Name = "panelLeft_Kaa";
            panelLeft_Kaa.Size = new Size(390, 347);
            panelLeft_Kaa.TabIndex = 1;
            // 
            // groupBoxIn_KAA
            // 
            groupBoxIn_KAA.Controls.Add(dataGridViewIn_Kaa);
            groupBoxIn_KAA.Location = new Point(3, 6);
            groupBoxIn_KAA.Name = "groupBoxIn_KAA";
            groupBoxIn_KAA.Size = new Size(381, 329);
            groupBoxIn_KAA.TabIndex = 1;
            groupBoxIn_KAA.TabStop = false;
            groupBoxIn_KAA.Text = "Ввод:";
            // 
            // dataGridViewIn_Kaa
            // 
            dataGridViewIn_Kaa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_Kaa.Location = new Point(9, 26);
            dataGridViewIn_Kaa.Name = "dataGridViewIn_Kaa";
            dataGridViewIn_Kaa.RowHeadersWidth = 51;
            dataGridViewIn_Kaa.Size = new Size(356, 297);
            dataGridViewIn_Kaa.TabIndex = 0;
            // 
            // panelRight_KAA
            // 
            panelRight_KAA.Controls.Add(groupBoxOut_KAA);
            panelRight_KAA.Dock = DockStyle.Right;
            panelRight_KAA.Location = new Point(400, 103);
            panelRight_KAA.Name = "panelRight_KAA";
            panelRight_KAA.Size = new Size(400, 347);
            panelRight_KAA.TabIndex = 1;
            // 
            // groupBoxOut_KAA
            // 
            groupBoxOut_KAA.Controls.Add(dataGridViewOut_KAA);
            groupBoxOut_KAA.Location = new Point(4, 6);
            groupBoxOut_KAA.Name = "groupBoxOut_KAA";
            groupBoxOut_KAA.Size = new Size(384, 329);
            groupBoxOut_KAA.TabIndex = 0;
            groupBoxOut_KAA.TabStop = false;
            groupBoxOut_KAA.Text = "Вывод:";
            // 
            // dataGridViewOut_KAA
            // 
            dataGridViewOut_KAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_KAA.Location = new Point(6, 26);
            dataGridViewOut_KAA.Name = "dataGridViewOut_KAA";
            dataGridViewOut_KAA.RowHeadersWidth = 51;
            dataGridViewOut_KAA.Size = new Size(372, 297);
            dataGridViewOut_KAA.TabIndex = 0;
            // 
            // splitter2
            // 
            splitter2.Location = new Point(390, 103);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(4, 347);
            splitter2.TabIndex = 2;
            splitter2.TabStop = false;
            // 
            // splitter3
            // 
            splitter3.Location = new Point(394, 103);
            splitter3.Name = "splitter3";
            splitter3.Size = new Size(4, 347);
            splitter3.TabIndex = 3;
            splitter3.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            toolTip1.Tag = "";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitter3);
            Controls.Add(splitter2);
            Controls.Add(panelLeft_Kaa);
            Controls.Add(panelRight_KAA);
            Controls.Add(panelTop_KAA);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelTop_KAA.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panelLeft_Kaa.ResumeLayout(false);
            groupBoxIn_KAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_Kaa).EndInit();
            panelRight_KAA.ResumeLayout(false);
            groupBoxOut_KAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_KAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_KAA;
        private Panel panelLeft_Kaa;
        private Panel panelRight_KAA;
        private Splitter splitter2;
        private Splitter splitter3;
        private Button buttonSave_KAA;
        private Button buttonAbout_KAA;
        private Button buttonRes_KAA;
        private Button buttonIn_KAA;
        private GroupBox groupBox1;
        private Label label1;
        private DataGridView dataGridViewIn_Kaa;
        private DataGridView dataGridViewOut_KAA;
        private GroupBox groupBoxIn_KAA;
        private GroupBox groupBoxOut_KAA;
        private OpenFileDialog openFileDialog1;
        private ToolTip toolTip1;
        private SaveFileDialog saveFileDialog1;
    }
}
