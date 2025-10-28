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
            label1 = new Label();
            DniPedido = new TextBox();
            button1 = new Button();
            NombreDetalleP = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ApellidoDetalleP = new RichTextBox();
            AgregarPedido = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 69);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 2;
            label1.Text = "DNI:";
            label1.Click += label1_Click;
            // 
            // DniPedido
            // 
            DniPedido.Location = new Point(122, 66);
            DniPedido.Name = "DniPedido";
            DniPedido.Size = new Size(169, 27);
            DniPedido.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(328, 64);
            button1.Name = "button1";
            button1.Size = new Size(125, 30);
            button1.TabIndex = 10;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // NombreDetalleP
            // 
            NombreDetalleP.Location = new Point(122, 212);
            NombreDetalleP.Name = "NombreDetalleP";
            NombreDetalleP.Size = new Size(167, 30);
            NombreDetalleP.TabIndex = 11;
            NombreDetalleP.Text = "";
            NombreDetalleP.TextChanged += NombreDetalleP_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 167);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 12;
            label2.Text = "Detalles del cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 215);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 13;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 279);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 14;
            label4.Text = "Apellido:";
            // 
            // ApellidoDetalleP
            // 
            ApellidoDetalleP.Location = new Point(122, 276);
            ApellidoDetalleP.Name = "ApellidoDetalleP";
            ApellidoDetalleP.Size = new Size(167, 30);
            ApellidoDetalleP.TabIndex = 15;
            ApellidoDetalleP.Text = "";
            ApellidoDetalleP.TextChanged += ApellidoDetalleP_TextChanged;
            // 
            // AgregarPedido
            // 
            AgregarPedido.Location = new Point(619, 69);
            AgregarPedido.Name = "AgregarPedido";
            AgregarPedido.Size = new Size(175, 57);
            AgregarPedido.TabIndex = 16;
            AgregarPedido.Text = "Agregar Pedido";
            AgregarPedido.UseVisualStyleBackColor = true;
            AgregarPedido.Click += AgregarPedido_Click;
            // 
            // button2
            // 
            button2.Location = new Point(115, 407);
            button2.Name = "button2";
            button2.Size = new Size(158, 29);
            button2.TabIndex = 19;
            button2.Text = "Volver al Menu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // FormPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 459);
            Controls.Add(button2);
            Controls.Add(AgregarPedido);
            Controls.Add(ApellidoDetalleP);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(NombreDetalleP);
            Controls.Add(button1);
            Controls.Add(DniPedido);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPedidos";
            Text = "FormPedidos";
            Load += FormPedidos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox DniPedido;
        private Button button1;
        private RichTextBox NombreDetalleP;
        private Label label2;
        private Label label3;
        private Label label4;
        private RichTextBox ApellidoDetalleP;
        private Button AgregarPedido;
        private Button button2;
    }
}