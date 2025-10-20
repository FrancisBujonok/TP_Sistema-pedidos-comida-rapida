namespace Menu_de_Gestion
{
    partial class FormModificarClientes
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
            Nombre = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            NombreModificar = new TextBox();
            ApellidoModificar = new TextBox();
            DireccionModificar = new TextBox();
            TelefonoModificar = new TextBox();
            DniModificar = new TextBox();
            button1 = new Button();
            label5 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(403, 87);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(67, 20);
            Nombre.TabIndex = 5;
            Nombre.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(403, 139);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 6;
            label1.Text = "Apellido:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(403, 193);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 7;
            label2.Text = "Direccion:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(403, 240);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 8;
            label3.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(559, 36);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 9;
            label4.Text = "Datos del Cliente";
            // 
            // NombreModificar
            // 
            NombreModificar.Location = new Point(501, 84);
            NombreModificar.Name = "NombreModificar";
            NombreModificar.Size = new Size(235, 27);
            NombreModificar.TabIndex = 10;
            NombreModificar.TextChanged += NombreModificar_TextChanged;
            // 
            // ApellidoModificar
            // 
            ApellidoModificar.Location = new Point(501, 132);
            ApellidoModificar.Name = "ApellidoModificar";
            ApellidoModificar.Size = new Size(235, 27);
            ApellidoModificar.TabIndex = 11;
            // 
            // DireccionModificar
            // 
            DireccionModificar.Location = new Point(501, 186);
            DireccionModificar.Name = "DireccionModificar";
            DireccionModificar.Size = new Size(235, 27);
            DireccionModificar.TabIndex = 12;
            // 
            // TelefonoModificar
            // 
            TelefonoModificar.Location = new Point(499, 233);
            TelefonoModificar.Name = "TelefonoModificar";
            TelefonoModificar.Size = new Size(237, 27);
            TelefonoModificar.TabIndex = 13;
            // 
            // DniModificar
            // 
            DniModificar.Location = new Point(62, 85);
            DniModificar.Name = "DniModificar";
            DniModificar.Size = new Size(235, 27);
            DniModificar.TabIndex = 14;
            DniModificar.TextChanged += DniModificar_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(110, 137);
            button1.Name = "button1";
            button1.Size = new Size(150, 29);
            button1.TabIndex = 15;
            button1.Text = "Buscar Cliente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 92);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 16;
            label5.Text = "Dni:";
            // 
            // button2
            // 
            button2.Location = new Point(535, 299);
            button2.Name = "button2";
            button2.Size = new Size(183, 29);
            button2.TabIndex = 17;
            button2.Text = "Guardar Cambios";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(81, 348);
            button3.Name = "button3";
            button3.Size = new Size(179, 52);
            button3.TabIndex = 22;
            button3.Text = "Volver al Menu";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FormModificarClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(DniModificar);
            Controls.Add(TelefonoModificar);
            Controls.Add(DireccionModificar);
            Controls.Add(ApellidoModificar);
            Controls.Add(NombreModificar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Nombre);
            Name = "FormModificarClientes";
            Text = "FormModificarClientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox NombreModificar;
        private TextBox ApellidoModificar;
        private TextBox DireccionModificar;
        private TextBox TelefonoModificar;
        private TextBox DniModificar;
        private Button button1;
        private Label label5;
        private Button button2;
        private Button button3;
    }
}