namespace Guia1_24_marzo_22PabloObregon
{
    partial class Form4
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
            dataGridView1 = new DataGridView();
            N1 = new DataGridViewTextBoxColumn();
            N2 = new DataGridViewTextBoxColumn();
            SUMA = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { N1, N2, SUMA });
            dataGridView1.Location = new Point(46, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(322, 151);
            dataGridView1.TabIndex = 0;
            // 
            // N1
            // 
            N1.HeaderText = "n1";
            N1.Name = "N1";
            // 
            // N2
            // 
            N2.HeaderText = "n2";
            N2.Name = "N2";
            // 
            // SUMA
            // 
            SUMA.HeaderText = "suma";
            SUMA.Name = "SUMA";
            // 
            // button1
            // 
            button1.Location = new Point(158, 74);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "CALCULAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 353);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewTextBoxColumn N1;
        private DataGridViewTextBoxColumn N2;
        private DataGridViewTextBoxColumn SUMA;
    }
}