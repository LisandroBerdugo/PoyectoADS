namespace Prueba2_Fase1
{
    partial class frmAgregarProveedor
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTelefono;

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
            txtTelefono = new TextBox();
            btnAceptar = new Button();
            lblNombre = new Label();
            lblTelefono = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(15, 25);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(15, 64);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(200, 23);
            txtTelefono.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(75, 100);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += BtnAceptar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(12, 48);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Teléfono";
            // 
            // frmAgregarProveedor
            // 
            ClientSize = new Size(234, 141);
            Controls.Add(lblTelefono);
            Controls.Add(lblNombre);
            Controls.Add(btnAceptar);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            MaximizeBox = false;
            MaximumSize = new Size(250, 180);
            MinimizeBox = false;
            MinimumSize = new Size(250, 180);
            Name = "frmAgregarProveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Proveedor";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
