namespace Prueba2_Fase1
{
    partial class FormAgregarMateriaPrima
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cbMateriasPrimas;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblMateriaPrima;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecioCompra;

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
            cbMateriasPrimas = new ComboBox();
            txtCantidad = new TextBox();
            txtPrecioCompra = new TextBox();
            btnAgregar = new Button();
            lblMateriaPrima = new Label();
            lblCantidad = new Label();
            lblPrecioCompra = new Label();

            SuspendLayout();

            // 
            // cbMateriasPrimas
            // 
            cbMateriasPrimas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMateriasPrimas.FormattingEnabled = true;
            cbMateriasPrimas.Location = new Point(12, 25);
            cbMateriasPrimas.Name = "cbMateriasPrimas";
            cbMateriasPrimas.Size = new Size(200, 23);
            cbMateriasPrimas.TabIndex = 0;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(12, 75);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 1;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(12, 125);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(100, 23);
            txtPrecioCompra.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 175);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblMateriaPrima
            // 
            lblMateriaPrima.AutoSize = true;
            lblMateriaPrima.Location = new Point(12, 9);
            lblMateriaPrima.Name = "lblMateriaPrima";
            lblMateriaPrima.Size = new Size(84, 15);
            lblMateriaPrima.TabIndex = 4;
            lblMateriaPrima.Text = "Materia Prima:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(12, 59);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(60, 15);
            lblCantidad.TabIndex = 5;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblPrecioCompra
            // 
            lblPrecioCompra.AutoSize = true;
            lblPrecioCompra.Location = new Point(12, 109);
            lblPrecioCompra.Name = "lblPrecioCompra";
            lblPrecioCompra.Size = new Size(89, 15);
            lblPrecioCompra.TabIndex = 6;
            lblPrecioCompra.Text = "Precio Compra:";
            // 
            // FormAgregarMateriaPrima
            // 
            ClientSize = new Size(284, 211);
            Controls.Add(lblPrecioCompra);
            Controls.Add(lblCantidad);
            Controls.Add(lblMateriaPrima);
            Controls.Add(btnAgregar);
            Controls.Add(txtPrecioCompra);
            Controls.Add(txtCantidad);
            Controls.Add(cbMateriasPrimas);
            Name = "FormAgregarMateriaPrima";
            Text = "Agregar Materia Prima";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
