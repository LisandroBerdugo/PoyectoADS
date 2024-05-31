namespace Prueba2_Fase1
{
    partial class frmPrueba3
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnFinalizarVenta;

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
            cbClientes = new ComboBox();
            cbProductos = new ComboBox();
            numCantidad = new NumericUpDown();
            txtPrecioVenta = new TextBox();
            btnAgregarProducto = new Button();
            dgvProductos = new DataGridView();
            btnFinalizarVenta = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // cbClientes
            // 
            cbClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(75, 28);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(260, 23);
            cbClientes.TabIndex = 0;
            // 
            // cbProductos
            // 
            cbProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProductos.FormattingEnabled = true;
            cbProductos.Location = new Point(456, 28);
            cbProductos.Name = "cbProductos";
            cbProductos.Size = new Size(260, 23);
            cbProductos.TabIndex = 1;
            cbProductos.SelectedIndexChanged += CbProductos_SelectedIndexChanged;
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(86, 74);
            numCantidad.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(120, 23);
            numCantidad.TabIndex = 2;
            numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numCantidad.Validating += NumCantidad_Validating;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(456, 74);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.ReadOnly = true;
            txtPrecioVenta.Size = new Size(120, 23);
            txtPrecioVenta.TabIndex = 3;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(827, 31);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(139, 23);
            btnAgregarProducto.TabIndex = 4;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += BtnAgregarProducto_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(22, 121);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.Size = new Size(944, 303);
            dgvProductos.TabIndex = 5;
            // 
            // btnFinalizarVenta
            // 
            btnFinalizarVenta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFinalizarVenta.Location = new Point(841, 448);
            btnFinalizarVenta.Name = "btnFinalizarVenta";
            btnFinalizarVenta.Size = new Size(125, 23);
            btnFinalizarVenta.TabIndex = 6;
            btnFinalizarVenta.Text = "Finalizar Venta";
            btnFinalizarVenta.UseVisualStyleBackColor = true;
            btnFinalizarVenta.Click += BtnFinalizarVenta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 31);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 7;
            label1.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(391, 31);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 8;
            label2.Text = "Producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(22, 78);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 9;
            label3.Text = "Cantidad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(363, 78);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 10;
            label4.Text = "Precio unitario:";
            // 
            // frmPrueba3
            // 
            BackColor = Color.FromArgb(37, 36, 81);
            ClientSize = new Size(989, 503);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnFinalizarVenta);
            Controls.Add(dgvProductos);
            Controls.Add(btnAgregarProducto);
            Controls.Add(txtPrecioVenta);
            Controls.Add(numCantidad);
            Controls.Add(cbProductos);
            Controls.Add(cbClientes);
            Name = "frmPrueba3";
            Text = "Realizar Venta";
            Load += FrmPrueba3_Load;
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
