namespace Prueba2_Fase1
{
    partial class FormAgregarProducto
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ErrorProvider errorProvider;

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
            components = new System.ComponentModel.Container();
            cbProductos = new ComboBox();
            numPrecioCompra = new NumericUpDown();
            btnAceptar = new Button();
            errorProvider = new ErrorProvider(components);
            txtCantidad = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numPrecioCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // cbProductos
            // 
            cbProductos.FormattingEnabled = true;
            cbProductos.Location = new Point(12, 12);
            cbProductos.Name = "cbProductos";
            cbProductos.Size = new Size(260, 23);
            cbProductos.TabIndex = 0;
            // 
            // numPrecioCompra
            // 
            numPrecioCompra.DecimalPlaces = 2;
            numPrecioCompra.Location = new Point(12, 65);
            numPrecioCompra.Maximum = new decimal(new int[] { 99999, 0, 0, 131072 });
            numPrecioCompra.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            numPrecioCompra.Name = "numPrecioCompra";
            numPrecioCompra.Size = new Size(120, 23);
            numPrecioCompra.TabIndex = 2;
            numPrecioCompra.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(197, 91);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += BtnAceptar_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(12, 36);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(120, 23);
            txtCantidad.TabIndex = 4;
            txtCantidad.Text = "1";
            txtCantidad.Validating += txtCantidad_Validating;
            // 
            // FormAgregarProducto
            // 
            ClientSize = new Size(284, 126);
            Controls.Add(txtCantidad);
            Controls.Add(btnAceptar);
            Controls.Add(numPrecioCompra);
            Controls.Add(cbProductos);
            Name = "FormAgregarProducto";
            Text = "Agregar Producto";
            ((System.ComponentModel.ISupportInitialize)numPrecioCompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.NumericUpDown numPrecioCompra;
        private System.Windows.Forms.Button btnAceptar;
        private TextBox txtCantidad;
    }
}
