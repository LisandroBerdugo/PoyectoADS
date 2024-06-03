namespace Prueba2_Fase1
{
    partial class frmCompras
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cbProveedores;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnRealizarCompra;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblProductos;

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
            cbProveedores = new ComboBox();
            btnAgregarProveedor = new Button();
            dgvProductos = new DataGridView();
            btnAgregarProducto = new Button();
            btnEliminarProducto = new Button();
            btnRealizarCompra = new Button();
            lblProveedor = new Label();
            lblProductos = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // cbProveedores
            // 
            cbProveedores.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProveedores.FormattingEnabled = true;
            cbProveedores.Location = new Point(12, 25);
            cbProveedores.Name = "cbProveedores";
            cbProveedores.Size = new Size(200, 23);
            cbProveedores.TabIndex = 0;
            // 
            // btnAgregarProveedor
            // 
            btnAgregarProveedor.Location = new Point(260, 25);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(131, 23);
            btnAgregarProveedor.TabIndex = 1;
            btnAgregarProveedor.Text = "Agregar Proveedor";
            btnAgregarProveedor.UseVisualStyleBackColor = true;
            btnAgregarProveedor.Click += BtnAgregarProveedor_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(12, 80);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(776, 300);
            dgvProductos.TabIndex = 2;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(12, 400);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(136, 23);
            btnAgregarProducto.TabIndex = 3;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += BtnAgregarProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.BackColor = Color.LightCoral;
            btnEliminarProducto.Location = new Point(193, 400);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(131, 23);
            btnEliminarProducto.TabIndex = 4;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = false;
            btnEliminarProducto.Click += BtnEliminarProducto_Click;
            // 
            // btnRealizarCompra
            // 
            btnRealizarCompra.Location = new Point(662, 400);
            btnRealizarCompra.Name = "btnRealizarCompra";
            btnRealizarCompra.Size = new Size(126, 23);
            btnRealizarCompra.TabIndex = 5;
            btnRealizarCompra.Text = "Realizar Compra";
            btnRealizarCompra.UseVisualStyleBackColor = true;
            btnRealizarCompra.Click += BtnRealizarCompra_Click;
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(12, 9);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(64, 15);
            lblProveedor.TabIndex = 6;
            lblProveedor.Text = "Proveedor:";
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Location = new Point(12, 64);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(64, 15);
            lblProductos.TabIndex = 7;
            lblProductos.Text = "Productos:";
            // 
            // frmCompras
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(lblProductos);
            Controls.Add(lblProveedor);
            Controls.Add(btnRealizarCompra);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnAgregarProducto);
            Controls.Add(dgvProductos);
            Controls.Add(btnAgregarProveedor);
            Controls.Add(cbProveedores);
            MaximizeBox = false;
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "frmCompras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compras";
            Load += frmCompras_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
