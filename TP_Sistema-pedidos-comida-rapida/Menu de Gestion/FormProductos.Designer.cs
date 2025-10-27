namespace Menu_de_Gestion
{
    partial class FormProductos
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
            labelNombre = new Label();
            labelPrecio = new Label();
            labelCategoria = new Label();
            labelStock = new Label();
            textNombre = new TextBox();
            textPrecio = new TextBox();
            textStock = new TextBox();
            buttonAgregar = new Button();
            buttonModificar = new Button();
            buttonEliminar = new Button();
            dataGridView1 = new DataGridView();
            buttonVolverAtras = new Button();
            textCategoria = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(66, 53);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(64, 20);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "Nombre";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Location = new Point(66, 104);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(50, 20);
            labelPrecio.TabIndex = 1;
            labelPrecio.Text = "Precio";
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(66, 159);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(74, 20);
            labelCategoria.TabIndex = 2;
            labelCategoria.Text = "Categoria";
            // 
            // labelStock
            // 
            labelStock.AutoSize = true;
            labelStock.Location = new Point(66, 211);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(45, 20);
            labelStock.TabIndex = 3;
            labelStock.Text = "Stock";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(149, 49);
            textNombre.Margin = new Padding(3, 4, 3, 4);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(195, 27);
            textNombre.TabIndex = 4;
            textNombre.TextChanged += textNombre_TextChanged;
            // 
            // textPrecio
            // 
            textPrecio.Location = new Point(149, 100);
            textPrecio.Margin = new Padding(3, 4, 3, 4);
            textPrecio.Name = "textPrecio";
            textPrecio.Size = new Size(195, 27);
            textPrecio.TabIndex = 5;
            // 
            // textStock
            // 
            textStock.Location = new Point(149, 207);
            textStock.Margin = new Padding(3, 4, 3, 4);
            textStock.Name = "textStock";
            textStock.Size = new Size(195, 27);
            textStock.TabIndex = 7;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(170, 277);
            buttonAgregar.Margin = new Padding(3, 4, 3, 4);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(139, 68);
            buttonAgregar.TabIndex = 8;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(403, 53);
            buttonModificar.Margin = new Padding(3, 4, 3, 4);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(115, 56);
            buttonModificar.TabIndex = 9;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(403, 175);
            buttonEliminar.Margin = new Padding(3, 4, 3, 4);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(115, 56);
            buttonEliminar.TabIndex = 10;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(552, 49);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(349, 296);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonVolverAtras
            // 
            buttonVolverAtras.Location = new Point(671, 392);
            buttonVolverAtras.Margin = new Padding(3, 4, 3, 4);
            buttonVolverAtras.Name = "buttonVolverAtras";
            buttonVolverAtras.Size = new Size(145, 35);
            buttonVolverAtras.TabIndex = 13;
            buttonVolverAtras.Text = "Volver Atrás";
            buttonVolverAtras.UseVisualStyleBackColor = true;
            buttonVolverAtras.Click += buttonVolverAtras_Click;
            // 
            // textCategoria
            // 
            textCategoria.FormattingEnabled = true;
            textCategoria.Items.AddRange(new object[] { "Bebida", "Comida" });
            textCategoria.Location = new Point(149, 156);
            textCategoria.Name = "textCategoria";
            textCategoria.Size = new Size(195, 28);
            textCategoria.TabIndex = 14;
            textCategoria.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 477);
            Controls.Add(textCategoria);
            Controls.Add(buttonVolverAtras);
            Controls.Add(dataGridView1);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonModificar);
            Controls.Add(buttonAgregar);
            Controls.Add(textStock);
            Controls.Add(textPrecio);
            Controls.Add(textNombre);
            Controls.Add(labelStock);
            Controls.Add(labelCategoria);
            Controls.Add(labelPrecio);
            Controls.Add(labelNombre);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormProductos";
            Text = "FormProductos";
            Load += FormProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNombre;
        private Label labelPrecio;
        private Label labelCategoria;
        private Label labelStock;
        private TextBox textNombre;
        private TextBox textPrecio;
        private TextBox textStock;
        private Button buttonAgregar;
        private Button buttonModificar;
        private Button buttonEliminar;
        private DataGridView dataGridView1;
        private Button buttonVolverAtras;
        private ComboBox textCategoria;
    }
}