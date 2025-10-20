namespace Menu_de_Gestion
{
    partial class FormClientes
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
            NombreCliente = new TextBox();
            ApellidoCliente = new TextBox();
            DireccionCliente = new TextBox();
            TelefonoCliente = new TextBox();
            Nombre = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            GuardarCliente = new Button();
            Modificar_Cliente = new Button();
            Eliminar_Cliente = new Button();
            label6 = new Label();
            DniCliente = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // NombreCliente
            // 
            NombreCliente.Location = new Point(106, 81);
            NombreCliente.Margin = new Padding(3, 4, 3, 4);
            NombreCliente.Name = "NombreCliente";
            NombreCliente.Size = new Size(177, 27);
            NombreCliente.TabIndex = 0;
            // 
            // ApellidoCliente
            // 
            ApellidoCliente.Location = new Point(106, 135);
            ApellidoCliente.Margin = new Padding(3, 4, 3, 4);
            ApellidoCliente.Name = "ApellidoCliente";
            ApellidoCliente.Size = new Size(177, 27);
            ApellidoCliente.TabIndex = 1;
            // 
            // DireccionCliente
            // 
            DireccionCliente.Location = new Point(106, 240);
            DireccionCliente.Margin = new Padding(3, 4, 3, 4);
            DireccionCliente.Name = "DireccionCliente";
            DireccionCliente.Size = new Size(177, 27);
            DireccionCliente.TabIndex = 2;
            // 
            // TelefonoCliente
            // 
            TelefonoCliente.Location = new Point(106, 292);
            TelefonoCliente.Margin = new Padding(3, 4, 3, 4);
            TelefonoCliente.Name = "TelefonoCliente";
            TelefonoCliente.Size = new Size(177, 27);
            TelefonoCliente.TabIndex = 3;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(34, 87);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(64, 20);
            Nombre.TabIndex = 4;
            Nombre.Text = "Nombre";
            Nombre.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 139);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 5;
            label1.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 244);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 6;
            label2.Text = "Direccion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 303);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 7;
            label3.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 41);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 8;
            label4.Text = "Crear Cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(435, 291);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 9;
            // 
            // GuardarCliente
            // 
            GuardarCliente.Location = new Point(102, 351);
            GuardarCliente.Margin = new Padding(3, 4, 3, 4);
            GuardarCliente.Name = "GuardarCliente";
            GuardarCliente.Size = new Size(181, 31);
            GuardarCliente.TabIndex = 10;
            GuardarCliente.Text = "Guardar Cliente";
            GuardarCliente.UseVisualStyleBackColor = true;
            GuardarCliente.Click += GuardarCliente_Click;
            // 
            // Modificar_Cliente
            // 
            Modificar_Cliente.Location = new Point(478, 59);
            Modificar_Cliente.Margin = new Padding(3, 4, 3, 4);
            Modificar_Cliente.Name = "Modificar_Cliente";
            Modificar_Cliente.Size = new Size(161, 83);
            Modificar_Cliente.TabIndex = 11;
            Modificar_Cliente.Text = "Modificar Cliente";
            Modificar_Cliente.UseVisualStyleBackColor = true;
            Modificar_Cliente.Click += Modificar_Cliente_Click;
            // 
            // Eliminar_Cliente
            // 
            Eliminar_Cliente.Location = new Point(478, 240);
            Eliminar_Cliente.Margin = new Padding(3, 4, 3, 4);
            Eliminar_Cliente.Name = "Eliminar_Cliente";
            Eliminar_Cliente.Size = new Size(161, 83);
            Eliminar_Cliente.TabIndex = 12;
            Eliminar_Cliente.Text = "Eliminar Cliente";
            Eliminar_Cliente.UseVisualStyleBackColor = true;
            Eliminar_Cliente.Click += Eliminar_Cliente_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 189);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 14;
            label6.Text = "DNI:";
            // 
            // DniCliente
            // 
            DniCliente.Location = new Point(106, 185);
            DniCliente.Margin = new Padding(3, 4, 3, 4);
            DniCliente.Name = "DniCliente";
            DniCliente.Size = new Size(177, 27);
            DniCliente.TabIndex = 13;
            DniCliente.TextChanged += DniCliente_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(655, 426);
            button2.Name = "button2";
            button2.Size = new Size(179, 52);
            button2.TabIndex = 22;
            button2.Text = "Volver al Menu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(DniCliente);
            Controls.Add(Eliminar_Cliente);
            Controls.Add(Modificar_Cliente);
            Controls.Add(GuardarCliente);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Nombre);
            Controls.Add(TelefonoCliente);
            Controls.Add(DireccionCliente);
            Controls.Add(ApellidoCliente);
            Controls.Add(NombreCliente);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormClientes";
            Text = "FormClientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NombreCliente;
        private TextBox ApellidoCliente;
        private TextBox DireccionCliente;
        private TextBox TelefonoCliente;
        private Label Nombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button GuardarCliente;
        private Button Modificar_Cliente;
        private Button Eliminar_Cliente;
        private Label label6;
        private TextBox DniCliente;
        private Button button2;
    }
}