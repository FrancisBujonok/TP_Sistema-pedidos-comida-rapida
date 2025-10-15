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
            textCategoria = new TextBox();
            textStock = new TextBox();
            buttonAgregar = new Button();
            buttonModificar = new Button();
            buttonEliminar = new Button();
            buttonLimpiar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(58, 40);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(51, 15);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "Nombre";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Location = new Point(58, 78);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(40, 15);
            labelPrecio.TabIndex = 1;
            labelPrecio.Text = "Precio";
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(58, 119);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(58, 15);
            labelCategoria.TabIndex = 2;
            labelCategoria.Text = "Categoria";
            // 
            // labelStock
            // 
            labelStock.AutoSize = true;
            labelStock.Location = new Point(58, 158);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(36, 15);
            labelStock.TabIndex = 3;
            labelStock.Text = "Stock";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(130, 37);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(171, 23);
            textNombre.TabIndex = 4;
            // 
            // textPrecio
            // 
            textPrecio.Location = new Point(130, 75);
            textPrecio.Name = "textPrecio";
            textPrecio.Size = new Size(171, 23);
            textPrecio.TabIndex = 5;
            // 
            // textCategoria
            // 
            textCategoria.Location = new Point(130, 116);
            textCategoria.Name = "textCategoria";
            textCategoria.Size = new Size(171, 23);
            textCategoria.TabIndex = 6;
            // 
            // textStock
            // 
            textStock.Location = new Point(130, 155);
            textStock.Name = "textStock";
            textStock.Size = new Size(171, 23);
            textStock.TabIndex = 7;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(149, 208);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(122, 51);
            buttonAgregar.TabIndex = 8;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(353, 40);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(101, 42);
            buttonModificar.TabIndex = 9;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(353, 131);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(101, 42);
            buttonEliminar.TabIndex = 10;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(353, 231);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(101, 28);
            buttonLimpiar.TabIndex = 11;
            buttonLimpiar.Text = "Limpiar Campos";
            buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(483, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(305, 222);
            dataGridView1.TabIndex = 12;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 325);
            Controls.Add(dataGridView1);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonModificar);
            Controls.Add(buttonAgregar);
            Controls.Add(textStock);
            Controls.Add(textCategoria);
            Controls.Add(textPrecio);
            Controls.Add(textNombre);
            Controls.Add(labelStock);
            Controls.Add(labelCategoria);
            Controls.Add(labelPrecio);
            Controls.Add(labelNombre);
            Name = "FormProductos";
            Text = "FormProductos";
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
        private TextBox textCategoria;
        private TextBox textStock;
        private Button buttonAgregar;
        private Button buttonModificar;
        private Button buttonEliminar;
        private Button buttonLimpiar;
        private DataGridView dataGridView1;
    }
}