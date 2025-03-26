namespace G1_24_Marzo_18_SebastianMurga
{
    partial class eje3
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            vector1 = new DataGridViewTextBoxColumn();
            vector2 = new DataGridViewTextBoxColumn();
            resultado = new DataGridViewTextBoxColumn();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(76, 34);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Vector 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { vector1, vector2, resultado });
            dataGridView1.Location = new Point(24, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(329, 150);
            dataGridView1.TabIndex = 1;
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
            // button3
            // 
            button3.Location = new Point(76, 97);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 0;
            button3.Text = "Suma";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(218, 97);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 0;
            button4.Text = "Resta";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(234, 34);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            button2.Text = "Vector 2 ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // eje3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 325);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "eje3";
            Text = "eje3";
            Load += eje3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn vector1;
        private DataGridViewTextBoxColumn vector2;
        private DataGridViewTextBoxColumn resultado;
        private Button button3;
        private Button button4;
        private Button button2;
    }
}