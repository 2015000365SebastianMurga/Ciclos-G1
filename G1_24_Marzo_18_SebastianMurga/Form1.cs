namespace G1_24_Marzo_18_SebastianMurga
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

            for (int cont = 1; cont <= 10; cont++)
            {
                int multi;
                multi = num1 * cont;
                //Agregar los datos en la tabla

                dataGridView1.Rows.Add(num1, cont, multi);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eje1 si = new eje1();
            si.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            eje2 no = new eje2();
            no.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            eje3 ddh = new eje3();
            ddh.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            eje4 jjj = new eje4();
            jjj.ShowDialog();
        }
    }
}

