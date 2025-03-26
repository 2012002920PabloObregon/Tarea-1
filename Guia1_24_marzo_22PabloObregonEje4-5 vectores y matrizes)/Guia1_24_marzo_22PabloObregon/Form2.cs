using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Guia1_24_marzo_22PabloObregon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1;
            num1 = Convert.ToInt32(textBox1.Text);

            int cont = 1;
            while (cont < 11)
            {
                int multi;
                multi = num1 * cont;

                dataGridView1.Rows.Add(num1, cont, multi);

                cont++;
            }
                
        }
    }
}
