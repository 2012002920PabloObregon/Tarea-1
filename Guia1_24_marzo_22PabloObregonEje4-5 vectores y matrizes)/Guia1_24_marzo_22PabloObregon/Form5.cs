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
            int[,] n1 =
            {
                { 1, 2, 3, 4, 5 },{ 5,4,3,2,1}
            };
            int[,] m2 =
            {
                { 6,7,8,9,10 },{ 10,9,8,7,6}
            };

            for (int cont = 0; cont < 5; cont++)
            {
                for(int cont2 = 0; cont2 < 2; cont2++)
                {
                    int mul = (n1[cont2, cont] * m2[cont2, cont]);
                    dataGridView1.Rows.Add(n1[cont2, cont], m2[cont2, cont], mul);
                }
            }

        }
    }
}
