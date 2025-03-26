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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] m1 =
            {
                {1,2,3,4,5}, {6,7,8,9,10}
            };
            int[,] m2 =
            {
                {2,3,5,2,1,}, {5,2,4,6,1}
            };

            for (int cont = 0; cont < 5; cont++)
            {
                for (int cont2 = 0; cont2 < 2; cont2++)
                {
                    int mul = m1[cont2, cont] * m2[cont2, cont];
                    dataGridView1.Rows.Add(m1[cont2, cont], m2[cont2, cont], multi);
                }
            }

        }
    }
}
