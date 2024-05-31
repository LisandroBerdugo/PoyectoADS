namespace Prueba2_Fase1
{
    partial class frmEditarCliente
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnGuardar;

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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(260, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(12, 41);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Apellido";
            txtApellido.Size = new Size(260, 23);
            txtApellido.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 70);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(260, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(12, 99);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(260, 23);
            txtTelefono.TabIndex = 3;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(12, 128);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Direccion";
            txtDireccion.Size = new Size(260, 23);
            txtDireccion.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(197, 157);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmEditarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 192);
            Controls.Add(btnGuardar);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            MaximizeBox = false;
            MaximumSize = new Size(300, 231);
            MinimumSize = new Size(300, 231);
            Name = "frmEditarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Cliente";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
