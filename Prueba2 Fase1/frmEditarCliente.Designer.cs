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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(260, 23);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.PlaceholderText = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(12, 41);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(260, 23);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.PlaceholderText = "Apellido";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 70);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(260, 23);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.PlaceholderText = "Email";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(12, 99);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(260, 23);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.PlaceholderText = "Telefono";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(12, 128);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(260, 23);
            this.txtDireccion.TabIndex = 4;
            this.txtDireccion.PlaceholderText = "Direccion";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(197, 157);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmEditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 192);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Name = "frmEditarCliente";
            this.Text = "Editar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
