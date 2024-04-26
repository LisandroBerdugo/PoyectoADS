namespace Prueba2_Fase1
{
    partial class frmAgregarUsu
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
            btnGuardar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            cbHabilitado = new CheckBox();
            cbVerificado = new CheckBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(485, 389);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(180, 389);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 67);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 2;
            label1.Text = "Usuario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(258, 236);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 5;
            label4.Text = "Rol:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(312, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            // 
            // cbHabilitado
            // 
            cbHabilitado.AutoSize = true;
            cbHabilitado.Location = new Point(311, 126);
            cbHabilitado.Name = "cbHabilitado";
            cbHabilitado.Size = new Size(81, 19);
            cbHabilitado.TabIndex = 7;
            cbHabilitado.Text = "Habilitado";
            cbHabilitado.UseVisualStyleBackColor = true;
            // 
            // cbVerificado
            // 
            cbVerificado.AutoSize = true;
            cbVerificado.Location = new Point(311, 184);
            cbVerificado.Name = "cbVerificado";
            cbVerificado.Size = new Size(78, 19);
            cbVerificado.TabIndex = 8;
            cbVerificado.Text = "Verificado";
            cbVerificado.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(311, 233);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // frmAgregarUsu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(cbVerificado);
            Controls.Add(cbHabilitado);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "frmAgregarUsu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Usuario";
            Load += frmAgregarUsu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnCancelar;
        private Label label1;
        private Label label4;
        private TextBox textBox1;
        private CheckBox cbHabilitado;
        private CheckBox cbVerificado;
        private ComboBox comboBox1;
    }
}