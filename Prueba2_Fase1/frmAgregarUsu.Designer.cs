namespace Prueba2_Fase1
{
    partial class frmAgregarUsu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBoxNombre = new TextBox();
            textBoxEmail = new TextBox();
            textBoxContraseña = new TextBox();
            comboBoxRol = new ComboBox();
            checkBoxActivo = new CheckBox();
            buttonGuardar = new Button();
            labelNombre = new Label();
            labelEmail = new Label();
            labelContraseña = new Label();
            labelRol = new Label();
            labelActivo = new Label();
            SuspendLayout();
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(111, 29);
            textBoxNombre.Margin = new Padding(4, 3, 4, 3);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(233, 23);
            textBoxNombre.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(111, 69);
            textBoxEmail.Margin = new Padding(4, 3, 4, 3);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(233, 23);
            textBoxEmail.TabIndex = 1;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Location = new Point(111, 110);
            textBoxContraseña.Margin = new Padding(4, 3, 4, 3);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(233, 23);
            textBoxContraseña.TabIndex = 2;
            // 
            // comboBoxRol
            // 
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Location = new Point(111, 150);
            comboBoxRol.Margin = new Padding(4, 3, 4, 3);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(233, 23);
            comboBoxRol.TabIndex = 3;
            // 
            // checkBoxActivo
            // 
            checkBoxActivo.AutoSize = true;
            checkBoxActivo.Location = new Point(111, 190);
            checkBoxActivo.Margin = new Padding(4, 3, 4, 3);
            checkBoxActivo.Name = "checkBoxActivo";
            checkBoxActivo.Size = new Size(60, 19);
            checkBoxActivo.TabIndex = 4;
            checkBoxActivo.Text = "Activo";
            checkBoxActivo.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(111, 231);
            buttonGuardar.Margin = new Padding(4, 3, 4, 3);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(88, 27);
            buttonGuardar.TabIndex = 5;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(29, 32);
            labelNombre.Margin = new Padding(4, 0, 4, 0);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(51, 15);
            labelNombre.TabIndex = 6;
            labelNombre.Text = "Nombre";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(29, 73);
            labelEmail.Margin = new Padding(4, 0, 4, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "Email";
            // 
            // labelContraseña
            // 
            labelContraseña.AutoSize = true;
            labelContraseña.Location = new Point(29, 113);
            labelContraseña.Margin = new Padding(4, 0, 4, 0);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(67, 15);
            labelContraseña.TabIndex = 8;
            labelContraseña.Text = "Contraseña";
            // 
            // labelRol
            // 
            labelRol.AutoSize = true;
            labelRol.Location = new Point(29, 153);
            labelRol.Margin = new Padding(4, 0, 4, 0);
            labelRol.Name = "labelRol";
            labelRol.Size = new Size(24, 15);
            labelRol.TabIndex = 9;
            labelRol.Text = "Rol";
            // 
            // labelActivo
            // 
            labelActivo.AutoSize = true;
            labelActivo.Location = new Point(29, 192);
            labelActivo.Margin = new Padding(4, 0, 4, 0);
            labelActivo.Name = "labelActivo";
            labelActivo.Size = new Size(41, 15);
            labelActivo.TabIndex = 10;
            labelActivo.Text = "Activo";
            // 
            // frmAgregarUsu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 278);
            Controls.Add(labelActivo);
            Controls.Add(labelRol);
            Controls.Add(labelContraseña);
            Controls.Add(labelEmail);
            Controls.Add(labelNombre);
            Controls.Add(buttonGuardar);
            Controls.Add(checkBoxActivo);
            Controls.Add(comboBoxRol);
            Controls.Add(textBoxContraseña);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxNombre);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(394, 317);
            MinimumSize = new Size(394, 317);
            Name = "frmAgregarUsu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Usuario";
            Load += frmAgregarUsu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.ComboBox comboBoxRol;
        private System.Windows.Forms.CheckBox checkBoxActivo;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.Label labelActivo;
    }
}
