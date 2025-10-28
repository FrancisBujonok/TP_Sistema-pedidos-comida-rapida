namespace Menu_de_Gestion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridVentasDia = new DataGridView();
            dataGridTopProductos = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridVentasDia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTopProductos).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(100, 97);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(116, 49);
            button1.TabIndex = 0;
            button1.Text = "Abrir Clientes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(281, 97);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(116, 49);
            button2.TabIndex = 1;
            button2.Text = "Abrir Productos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(457, 97);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(116, 49);
            button3.TabIndex = 2;
            button3.Text = "Abrir Pedidos";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 63);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 3;
            label1.Text = "Gestion de Clientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 63);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 4;
            label2.Text = "Gestion de Productos";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(457, 63);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 5;
            label3.Text = "Gestion de Pedidos";
            // 
            // dataGridVentasDia
            // 
            dataGridVentasDia.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridVentasDia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridVentasDia.Location = new Point(28, 224);
            dataGridVentasDia.Name = "dataGridVentasDia";
            dataGridVentasDia.Size = new Size(310, 226);
            dataGridVentasDia.TabIndex = 6;
            // 
            // dataGridTopProductos
            // 
            dataGridTopProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTopProductos.Location = new Point(357, 224);
            dataGridTopProductos.Name = "dataGridTopProductos";
            dataGridTopProductos.Size = new Size(312, 226);
            dataGridTopProductos.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(420, 192);
            label4.Name = "label4";
            label4.Size = new Size(188, 15);
            label4.TabIndex = 8;
            label4.Text = "TOP 5 PROUCTOS MÁS VENDIDOS";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(114, 192);
            label5.Name = "label5";
            label5.Size = new Size(119, 15);
            label5.TabIndex = 9;
            label5.Text = "TOP VENTAS DEL DÍA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 462);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dataGridTopProductos);
            Controls.Add(dataGridVentasDia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridVentasDia).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTopProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridVentasDia;
        private DataGridView dataGridTopProductos;
        private Label label4;
        private Label label5;
    }
}
