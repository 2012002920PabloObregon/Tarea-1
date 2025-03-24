using System.Numerics;

namespace Guia1_24_marzo_22PabloObregon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);

            for (int cont = 1; cont < 11; cont++)
            {
                int multi;
                multi = num1 * cont;

                dataGridView1.Rows.Add(num1, cont, multi);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 v1 = new Form2();
            v1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 v2 = new Form3();
            v2.Show();
        }
    }
}
