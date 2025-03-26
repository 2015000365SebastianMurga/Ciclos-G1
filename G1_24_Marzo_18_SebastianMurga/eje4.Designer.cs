namespace G1_24_Marzo_18_SebastianMurga
{
    partial class eje4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            vector1 = new DataGridViewTextBoxColumn();
            vector2 = new DataGridViewTextBoxColumn();
            resultado = new DataGridViewTextBoxColumn();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { vector1, vector2, resultado });
            dataGridView1.Location = new Point(28, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(329, 150);
            dataGridView1.TabIndex = 6;
            // 
            // vector1
            // 
            vector1.HeaderText = "Vector 1";
            vector1.Name = "vector1";
            // 
            // vector2
            // 
            vector2.HeaderText = "Vector 2";
            vector2.Name = "vector2";
            // 
            // resultado
            // 
            resultado.HeaderText = "Resultado";
            resultado.Name = "resultado";
            // 
            // button4
            // 
            button4.Location = new Point(222, 97);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 2;
            button4.Text = "Division";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(80, 97);
            button3.Name = "button3";
            button3.Size = new Size(98, 23);
            button3.TabIndex = 3;
            button3.Text = "Multiplicacion";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(238, 34);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Matriz 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(80, 34);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Matriz 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // eje4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 356);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "eje4";
            Text = "eje4";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn vector1;
        private DataGridViewTextBoxColumn vector2;
        private DataGridViewTextBoxColumn resultado;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}