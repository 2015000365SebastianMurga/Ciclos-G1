using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G1_24_Marzo_18_SebastianMurga
{
    public partial class eje2 : Form
    {
        public eje2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int cont = 1;
            while (cont <= 10)
            {
                int multi;
                multi = n * cont;
                //Agregar los datos en la tabla

                dataGridView1.Rows.Add(n, cont, multi);
                cont++;
            }
        }
    }
}
