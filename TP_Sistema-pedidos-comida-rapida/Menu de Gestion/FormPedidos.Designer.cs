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
            label2 = new Label();
            label3 = new Label();
            DescripcionPedido = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(43, 39);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(126, 31);
            button1.TabIndex = 0;
            button1.Text = "Agregar Pedido";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(55, 92);
            button2.Name = "button2";
            button2.Size = new Size(150, 29);
            button2.TabIndex = 1;
            button2.Text = "Eliminar Pedido";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(348, 98);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 2;
            label1.Text = "DNI:";
            // 
            // DniPedido
            // 
            DniPedido.Location = new Point(392, 98);
            DniPedido.Name = "DniPedido";
            DniPedido.Size = new Size(125, 27);
            DniPedido.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 47);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 143);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 5;
            label3.Text = "DescripciónPedido";
            // 
            // DescripcionPedido
            // 
            DescripcionPedido.Location = new Point(405, 140);
            DescripcionPedido.Name = "DescripcionPedido";
            DescripcionPedido.Size = new Size(125, 27);
            DescripcionPedido.TabIndex = 6;
            // 
            // FormPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(DescripcionPedido);
            Controls.Add(label3);
            Controls.Add(label2);
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
        private Label label2;
        private Label label3;
        private TextBox DescripcionPedido;
    }
}