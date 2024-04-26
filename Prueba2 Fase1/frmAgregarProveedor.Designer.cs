namespace Prueba2_Fase1
{
    partial class frmAgregarProveedor
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
            comboBox1 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(502, 229);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(451, 237);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 21;
            label4.Text = "Estado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 237);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 20;
            label3.Text = "Telefono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(439, 116);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 19;
            label2.Text = "Direccion:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 116);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 18;
            label1.Text = "Nombre:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(246, 234);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(502, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(246, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 15;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(246, 358);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_2;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(551, 358);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(279, 23);
            label5.Name = "label5";
            label5.Size = new Size(280, 32);
            label5.TabIndex = 23;
            label5.Text = "AGREGAR PROVEEDORES";
            // 
            // frmAgregarProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "frmAgregarProveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAgregarProveedor";
            Load += frmAgregarProveedor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label label5;
    }
}