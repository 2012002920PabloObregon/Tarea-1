namespace Guia1_24_marzo_22PabloObregon
{
    partial class Form5
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            m1 = new DataGridViewTextBoxColumn();
            m2 = new DataGridViewTextBoxColumn();
            multi = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(175, 110);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "CALCULAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { m1, m2, multi });
            dataGridView1.Location = new Point(43, 160);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(343, 121);
            dataGridView1.TabIndex = 2;
            // 
            // m1
            // 
            m1.HeaderText = "M1";
            m1.Name = "m1";
            // 
            // m2
            // 
            m2.HeaderText = "M2";
            m2.Name = "m2";
            // 
            // multi
            // 
            multi.HeaderText = "MULTIPLICACION";
            multi.Name = "multi";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 318);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn m1;
        private DataGridViewTextBoxColumn m2;
        private DataGridViewTextBoxColumn multi;
    }
}