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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] n1 = {1,2,3,4,5};
            int[] n2 = {5,4,3,2,1};

            for (int cont = 0; cont < 5; cont++)
            {
                int suma = n1[cont] + n2[cont];
                dataGridView1.Rows.Add(n1[cont], n2[cont],suma);
            }

        }
    }
}
