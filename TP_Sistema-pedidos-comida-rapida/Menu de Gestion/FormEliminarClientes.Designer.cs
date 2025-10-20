namespace Menu_de_Gestion
{
    partial class FormEliminarClientes
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
            label5 = new Label();
            button1 = new Button();
            DniEliminar = new TextBox();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 106);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 19;
            label5.Text = "Dni:";
            // 
            // button1
            // 
            button1.Location = new Point(133, 151);
            button1.Name = "button1";
            button1.Size = new Size(150, 29);
            button1.TabIndex = 18;
            button1.Text = "Buscar Cliente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DniEliminar
            // 
            DniEliminar.Location = new Point(85, 99);
            DniEliminar.Name = "DniEliminar";
            DniEliminar.Size = new Size(235, 27);
            DniEliminar.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 47);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 20;
            label1.Text = "Eliminar Cliente";
            // 
            // button2
            // 
            button2.Location = new Point(546, 369);
            button2.Name = "button2";
            button2.Size = new Size(179, 52);
            button2.TabIndex = 21;
            button2.Text = "Volver al Menu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormEliminarClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(DniEliminar);
            Name = "FormEliminarClientes";
            Text = "FormEliminarClientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button button1;
        private TextBox DniEliminar;
        private Label label1;
        private Button button2;
    }
}