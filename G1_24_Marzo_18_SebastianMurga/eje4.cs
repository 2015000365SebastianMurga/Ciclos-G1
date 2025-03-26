using Microsoft.VisualBasic;
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
    public partial class eje4 : Form
    {
        public int[,] ve2;
        public int[,] ve1;
        int mult = 0;
        int div = 0;
        public eje4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ve1 = new int[2,2];
            for (int i = 0; i < 2; i++)
            {
                for (int f = 0; f < 2; f++)
                {
                    ve1[i,f] = Convert.ToInt32(Interaction.InputBox("Ingresar un Valor para la Matriz "));
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ve2 = new int[2,2];
            for (int i = 0; i < 2; i++)
            {
                for (int f = 0; f < 2; f++)
                {
                    ve2[i, f] = Convert.ToInt32(Interaction.InputBox("Ingresar un Valor para el Vector "));
                }
                

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int f = 0; f < 2; f++)
                {
                    mult = ve1[i,f] * ve2[i,f];

                    dataGridView1.Rows.Add(ve1[i,f], ve2[i,f], mult);
                }
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int f = 0; f < 2; f++)
                {
                    div = ve1[i, f] / ve2[i, f];

                    dataGridView1.Rows.Add(ve1[i, f], ve2[i, f], div);
                }

            }
        }
    }
}
