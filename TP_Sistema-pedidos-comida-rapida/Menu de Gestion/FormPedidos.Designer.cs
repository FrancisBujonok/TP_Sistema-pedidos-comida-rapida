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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(290, 24);
            button1.Name = "button1";
            button1.Size = new Size(110, 23);
            button1.TabIndex = 0;
            button1.Text = "Agregar Pedido";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(290, 109);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(131, 22);
            button2.TabIndex = 1;
            button2.Text = "Eliminar Pedido";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 32);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 2;
            label1.Text = "DNI:";
            label1.Click += label1_Click;
            // 
            // DniPedido
            // 
            DniPedido.Location = new Point(127, 29);
            DniPedido.Margin = new Padding(3, 2, 3, 2);
            DniPedido.Name = "DniPedido";
            DniPedido.Size = new Size(110, 23);
            DniPedido.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 71);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 5;
            label3.Text = "Descripción Pedido:";
            // 
            // DescripcionPedido
            // 
            DescripcionPedido.Location = new Point(127, 68);
            DescripcionPedido.Margin = new Padding(3, 2, 3, 2);
            DescripcionPedido.Name = "DescripcionPedido";
            DescripcionPedido.Size = new Size(110, 23);
            DescripcionPedido.TabIndex = 6;
            // 
            // button3
            // 
            button3.Location = new Point(290, 67);
            button3.Name = "button3";
            button3.Size = new Size(97, 23);
            button3.TabIndex = 7;
            button3.Text = "Buscar Pedido";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(440, 24);
            button4.Name = "button4";
            button4.Size = new Size(107, 23);
            button4.TabIndex = 8;
            button4.Text = "Actualizar Estado";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // comboEstado
            // 
            comboEstado.FormattingEnabled = true;
            comboEstado.Items.AddRange(new object[] { "Pendiente", "En preparación", "Entregado", "Cancelado" });
            comboEstado.Location = new Point(440, 53);
            comboEstado.Name = "comboEstado";
            comboEstado.Size = new Size(121, 23);
            comboEstado.TabIndex = 9;
            // 
            // FechaPedido
            // 
            FechaPedido.Location = new Point(127, 108);
            FechaPedido.Name = "FechaPedido";
            FechaPedido.Size = new Size(100, 23);
            FechaPedido.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 111);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 11;
            label2.Text = "Fecha Pedido:";
            label2.Click += label2_Click;
            // 
            // FormPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}