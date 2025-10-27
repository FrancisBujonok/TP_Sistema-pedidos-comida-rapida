namespace Menu_de_Gestion
{
    partial class FormPedidos
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
            button2 = new Button();
            label1 = new Label();
            DniPedido = new TextBox();
            label3 = new Label();
            DescripcionPedido = new TextBox();
            button3 = new Button();
            button4 = new Button();
            comboEstado = new ComboBox();
            FechaPedido = new TextBox();
            label2 = new Label();
            buttonVolverAtras = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(160, 207);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(169, 78);
            button1.TabIndex = 0;
            button1.Text = "Agregar Pedido";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(424, 331);
            button2.Name = "button2";
            button2.Size = new Size(163, 67);
            button2.TabIndex = 1;
            button2.Text = "Eliminar Pedido";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 42);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 2;
            label1.Text = "DNI:";
            label1.Click += label1_Click;
            // 
            // DniPedido
            // 
            DniPedido.Location = new Point(160, 39);
            DniPedido.Name = "DniPedido";
            DniPedido.Size = new Size(169, 27);
            DniPedido.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 95);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 5;
            label3.Text = "Descripción Pedido:";
            // 
            // DescripcionPedido
            // 
            DescripcionPedido.Location = new Point(160, 92);
            DescripcionPedido.Name = "DescripcionPedido";
            DescripcionPedido.Size = new Size(169, 27);
            DescripcionPedido.TabIndex = 6;
            // 
            // button3
            // 
            button3.Location = new Point(160, 331);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(169, 67);
            button3.TabIndex = 7;
            button3.Text = "Buscar Pedido";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(488, 53);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(171, 62);
            button4.TabIndex = 8;
            button4.Text = "Actualizar Estado";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // comboEstado
            // 
            comboEstado.FormattingEnabled = true;
            comboEstado.Items.AddRange(new object[] { "Pendiente", "En preparación", "Entregado", "Cancelado" });
            comboEstado.Location = new Point(475, 144);
            comboEstado.Margin = new Padding(3, 4, 3, 4);
            comboEstado.Name = "comboEstado";
            comboEstado.Size = new Size(184, 28);
            comboEstado.TabIndex = 9;
            comboEstado.SelectedIndexChanged += comboEstado_SelectedIndexChanged;
            // 
            // FechaPedido
            // 
            FechaPedido.Location = new Point(160, 145);
            FechaPedido.Margin = new Padding(3, 4, 3, 4);
            FechaPedido.Name = "FechaPedido";
            FechaPedido.Size = new Size(169, 27);
            FechaPedido.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 148);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 11;
            label2.Text = "Fecha Pedido:";
            label2.Click += label2_Click;
            // 
            // buttonVolverAtras
            // 
            buttonVolverAtras.Location = new Point(707, 346);
            buttonVolverAtras.Margin = new Padding(3, 4, 3, 4);
            buttonVolverAtras.Name = "buttonVolverAtras";
            buttonVolverAtras.Size = new Size(177, 37);
            buttonVolverAtras.TabIndex = 12;
            buttonVolverAtras.Text = "Volver Atrás";
            buttonVolverAtras.UseVisualStyleBackColor = true;
            buttonVolverAtras.Click += buttonVolverAtras_Click;
            // 
            // FormPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 459);
            Controls.Add(buttonVolverAtras);
            Controls.Add(label2);
            Controls.Add(FechaPedido);
            Controls.Add(comboEstado);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(DescripcionPedido);
            Controls.Add(label3);
            Controls.Add(DniPedido);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPedidos";
            Text = "FormPedidos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox DniPedido;
        private Label label3;
        private TextBox DescripcionPedido;
        private Button button3;
        private Button button4;
        private ComboBox comboEstado;
        private TextBox FechaPedido;
        private Label label2;
        private Button buttonVolverAtras;
    }
}