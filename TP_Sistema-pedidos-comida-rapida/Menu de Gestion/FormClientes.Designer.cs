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
            SuspendLayout();
            // 
            // NombreCliente
            // 
            NombreCliente.Location = new Point(93, 61);
            NombreCliente.Name = "NombreCliente";
            NombreCliente.Size = new Size(100, 23);
            NombreCliente.TabIndex = 0;
            // 
            // ApellidoCliente
            // 
            ApellidoCliente.Location = new Point(93, 114);
            ApellidoCliente.Name = "ApellidoCliente";
            ApellidoCliente.Size = new Size(100, 23);
            ApellidoCliente.TabIndex = 1;
            // 
            // DireccionCliente
            // 
            DireccionCliente.Location = new Point(93, 168);
            DireccionCliente.Name = "DireccionCliente";
            DireccionCliente.Size = new Size(100, 23);
            DireccionCliente.TabIndex = 2;
            // 
            // TelefonoCliente
            // 
            TelefonoCliente.Location = new Point(93, 219);
            TelefonoCliente.Name = "TelefonoCliente";
            TelefonoCliente.Size = new Size(100, 23);
            TelefonoCliente.TabIndex = 3;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(30, 65);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 4;
            Nombre.Text = "Nombre";
            Nombre.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 117);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 5;
            label1.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 171);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 6;
            label2.Text = "Direccion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 227);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 7;
            label3.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 31);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 8;
            label4.Text = "Crear Cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(381, 218);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 9;
            // 
            // GuardarCliente
            // 
            GuardarCliente.Location = new Point(89, 263);
            GuardarCliente.Name = "GuardarCliente";
            GuardarCliente.Size = new Size(104, 23);
            GuardarCliente.TabIndex = 10;
            GuardarCliente.Text = "GuardarCliente";
            GuardarCliente.UseVisualStyleBackColor = true;
            GuardarCliente.Click += GuardarCliente_Click;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}