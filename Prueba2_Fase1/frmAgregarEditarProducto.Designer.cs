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
        private System.Windows.Forms.ComboBox cbMateriaPrima;
        private System.Windows.Forms.Button btnAgregarMateriaPrima;
        private System.Windows.Forms.DataGridView dgvMateriaPrimaNecesaria;

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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbMateriaPrima = new System.Windows.Forms.ComboBox();
            this.btnAgregarMateriaPrima = new System.Windows.Forms.Button();
            this.dgvMateriaPrimaNecesaria = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriaPrimaNecesaria)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(100, 60);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(200, 23);
            this.txtDescripcion.TabIndex = 1;
            // 
            // numPrecio
            // 
            this.numPrecio.DecimalPlaces = 2;
            this.numPrecio.Location = new System.Drawing.Point(100, 100);
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(120, 23);
            this.numPrecio.TabIndex = 2;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(20, 20);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(54, 15);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(20, 60);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(72, 15);
            this.labelDescripcion.TabIndex = 4;
            this.labelDescripcion.Text = "Descripción:";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(20, 100);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(43, 15);
            this.labelPrecio.TabIndex = 5;
            this.labelPrecio.Text = "Precio:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(100, 140);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbMateriaPrima
            // 
            this.cbMateriaPrima.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMateriaPrima.FormattingEnabled = true;
            this.cbMateriaPrima.Location = new System.Drawing.Point(20, 180);
            this.cbMateriaPrima.Name = "cbMateriaPrima";
            this.cbMateriaPrima.Size = new System.Drawing.Size(180, 23);
            this.cbMateriaPrima.TabIndex = 7;
            // 
            // btnAgregarMateriaPrima
            // 
            this.btnAgregarMateriaPrima.Location = new System.Drawing.Point(220, 180);
            this.btnAgregarMateriaPrima.Name = "btnAgregarMateriaPrima";
            this.btnAgregarMateriaPrima.Size = new System.Drawing.Size(80, 23);
            this.btnAgregarMateriaPrima.TabIndex = 8;
            this.btnAgregarMateriaPrima.Text = "Agregar";
            this.btnAgregarMateriaPrima.UseVisualStyleBackColor = true;
            this.btnAgregarMateriaPrima.Click += new System.EventHandler(this.btnAgregarMateriaPrima_Click);
            // 
            // dgvMateriaPrimaNecesaria
            // 
            this.dgvMateriaPrimaNecesaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriaPrimaNecesaria.Location = new System.Drawing.Point(20, 220);
            this.dgvMateriaPrimaNecesaria.Name = "dgvMateriaPrimaNecesaria";
            this.dgvMateriaPrimaNecesaria.Size = new System.Drawing.Size(340, 150);
            this.dgvMateriaPrimaNecesaria.TabIndex = 9;
            // 
            // frmAgregarEditarProducto
            // 
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.dgvMateriaPrimaNecesaria);
            this.Controls.Add(this.btnAgregarMateriaPrima);
            this.Controls.Add(this.cbMateriaPrima);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.numPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(416, 439);
            this.MinimumSize = new System.Drawing.Size(416, 439);
            this.Name = "frmAgregarEditarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar/Editar Producto";
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriaPrimaNecesaria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
