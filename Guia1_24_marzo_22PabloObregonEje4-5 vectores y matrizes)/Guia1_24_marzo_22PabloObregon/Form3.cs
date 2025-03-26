using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia1_24_marzo_22PabloObregon
{
    public partial class Form3 : Form
    {
        int cont = 1;
        int num;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            num = Convert.ToInt32(textBox1.Text);
            do
            {
                int multi;
                multi = num * cont;
                dataGridView1.Rows.Add(num, cont, multi);
                cont++;
            }
            while (cont < 11);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
