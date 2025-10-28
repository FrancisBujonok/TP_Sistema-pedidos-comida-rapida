namespace Menu_de_Gestion
{
    partial class FormAgregarPedido
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
            dgvDetallePedido = new DataGridView();
            label1 = new Label();
            ProductoDetalle = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            CantidadDetalle = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            TotalDetalle = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDetallePedido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CantidadDetalle).BeginInit();
            SuspendLayout();
            // 
            // dgvDetallePedido
            // 
            dgvDetallePedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallePedido.Location = new Point(460, 78);
            dgvDetallePedido.Name = "dgvDetallePedido";
            dgvDetallePedido.RowHeadersWidth = 51;
            dgvDetallePedido.Size = new Size(300, 188);
            dgvDetallePedido.TabIndex = 0;
            dgvDetallePedido.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(552, 43);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 1;
            label1.Text = "Detalle de pedido";
            // 
            // ProductoDetalle
            // 
            ProductoDetalle.FormattingEnabled = true;
            ProductoDetalle.Location = new Point(99, 100);
            ProductoDetalle.Name = "ProductoDetalle";
            ProductoDetalle.Size = new Size(155, 28);
            ProductoDetalle.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 105);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 3;
            label2.Text = "Producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 156);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 4;
            label3.Text = "Cantidad:";
            // 
            // CantidadDetalle
            // 
            CantidadDetalle.Location = new Point(99, 149);
            CantidadDetalle.Name = "CantidadDetalle";
            CantidadDetalle.Size = new Size(155, 27);
            CantidadDetalle.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(99, 218);
            button1.Name = "button1";
            button1.Size = new Size(158, 29);
            button1.TabIndex = 6;
            button1.Text = "Agregar Producto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(99, 375);
            button2.Name = "button2";
            button2.Size = new Size(158, 29);
            button2.TabIndex = 7;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(543, 375);
            button3.Name = "button3";
            button3.Size = new Size(158, 29);
            button3.TabIndex = 8;
            button3.Text = "Guardar Pedido";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(485, 302);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 9;
            label4.Text = "Total:";
            // 
            // TotalDetalle
            // 
            TotalDetalle.Location = new Point(536, 299);
            TotalDetalle.Name = "TotalDetalle";
            TotalDetalle.Size = new Size(146, 30);
            TotalDetalle.TabIndex = 10;
            TotalDetalle.Text = "";
            TotalDetalle.TextChanged += richTextBox1_TextChanged;
            // 
            // FormAgregarPedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TotalDetalle);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CantidadDetalle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ProductoDetalle);
            Controls.Add(label1);
            Controls.Add(dgvDetallePedido);
            Name = "FormAgregarPedido";
            Text = "FormAgregarPedido";
            Load += FormAgregarPedido_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetallePedido).EndInit();
            ((System.ComponentModel.ISupportInitialize)CantidadDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDetallePedido;
        private Label label1;
        private ComboBox ProductoDetalle;
        private Label label2;
        private Label label3;
        private NumericUpDown CantidadDetalle;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private RichTextBox TotalDetalle;
    }
}