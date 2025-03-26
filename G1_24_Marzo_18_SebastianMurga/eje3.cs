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
using static System.Net.Mime.MediaTypeNames;

namespace G1_24_Marzo_18_SebastianMurga
{
    public partial class eje3 : Form
    {
        public int[] v2;
        public int[] v1;
        int suma = 0;
        int resta = 0;
        public eje3()
        {
            InitializeComponent();
        }

        private void eje3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            v1 = new int[3];
            for (int i = 0; i < 3; i++)
            {
                v1[i] = Convert.ToInt32(Interaction.InputBox("Ingresar un Valor para el Vector "));

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            v2 = new int[3];
            for (int i = 0; i < 3; i++)
            {
                v2[i] = Convert.ToInt32(Interaction.InputBox("Ingresar un Valor para el Vector "));

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                suma = v1[i] + v2[i];

                dataGridView1.Rows.Add(v1[i], v2[i], suma);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                resta = v1[i] - v2[i];

                dataGridView1.Rows.Add(v1[i], v2[i], resta);
            }
        }
    }
}
