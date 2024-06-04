namespace Prueba2_Fase1
{
    partial class frmCompras
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cbProveedores;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Button btnAgregarItem;
        private System.Windows.Forms.Button btnEliminarItem;
        private System.Windows.Forms.Button btnRealizarCompra;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblItems;

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
            dgvItems = new DataGridView();
            btnAgregarItem = new Button();
            btnEliminarItem = new Button();
            btnRealizarCompra = new Button();
            lblProveedor = new Label();
            lblItems = new Label();

            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
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
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(12, 80);
            dgvItems.Name = "dgvItems";
            dgvItems.Size = new Size(776, 300);
            dgvItems.TabIndex = 2;
            // 
            // btnAgregarItem
            // 
            btnAgregarItem.Location = new Point(12, 400);
            btnAgregarItem.Name = "btnAgregarItem";
            btnAgregarItem.Size = new Size(136, 23);
            btnAgregarItem.TabIndex = 3;
            btnAgregarItem.Text = "Agregar Materia Prima";
            btnAgregarItem.UseVisualStyleBackColor = true;
            btnAgregarItem.Click += BtnAgregarItem_Click;
            // 
            // btnEliminarItem
            // 
            btnEliminarItem.BackColor = Color.LightCoral;
            btnEliminarItem.Location = new Point(193, 400);
            btnEliminarItem.Name = "btnEliminarItem";
            btnEliminarItem.Size = new Size(131, 23);
            btnEliminarItem.TabIndex = 4;
            btnEliminarItem.Text = "Eliminar Materia Prima";
            btnEliminarItem.UseVisualStyleBackColor = false;
            btnEliminarItem.Click += BtnEliminarItem_Click;
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
            // lblItems
            // 
            lblItems.AutoSize = true;
            lblItems.Location = new Point(12, 64);
            lblItems.Name = "lblItems";
            lblItems.Size = new Size(84, 15);
            lblItems.TabIndex = 7;
            lblItems.Text = "Materias Primas:";
            // 
            // frmCompras
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(lblItems);
            Controls.Add(lblProveedor);
            Controls.Add(btnRealizarCompra);
            Controls.Add(btnEliminarItem);
            Controls.Add(btnAgregarItem);
            Controls.Add(dgvItems);
            Controls.Add(btnAgregarProveedor);
            Controls.Add(cbProveedores);
            MaximizeBox = false;
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "frmCompras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compras";
            Load += frmCompras_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
