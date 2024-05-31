namespace Prueba2_Fase1
{
    partial class frmAgregarEditarProducto
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelPrecio;
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
            txtDescripcion = new TextBox();
            numPrecio = new NumericUpDown();
            labelNombre = new Label();
            labelDescripcion = new Label();
            labelPrecio = new Label();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(100, 20);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(100, 60);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(200, 23);
            txtDescripcion.TabIndex = 1;
            // 
            // numPrecio
            // 
            numPrecio.DecimalPlaces = 2;
            numPrecio.Location = new Point(100, 100);
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(120, 23);
            numPrecio.TabIndex = 2;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(20, 20);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(54, 15);
            labelNombre.TabIndex = 3;
            labelNombre.Text = "Nombre:";
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Location = new Point(20, 60);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(72, 15);
            labelDescripcion.TabIndex = 4;
            labelDescripcion.Text = "Descripción:";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Location = new Point(20, 100);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(43, 15);
            labelPrecio.TabIndex = 5;
            labelPrecio.Text = "Precio:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(100, 140);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 30);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmAgregarEditarProducto
            // 
            ClientSize = new Size(350, 200);
            Controls.Add(btnGuardar);
            Controls.Add(labelPrecio);
            Controls.Add(labelDescripcion);
            Controls.Add(labelNombre);
            Controls.Add(numPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            MaximizeBox = false;
            MaximumSize = new Size(366, 239);
            MinimumSize = new Size(366, 239);
            Name = "frmAgregarEditarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar/Editar Producto";
            ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
