namespace Prueba2_Fase1
{
    partial class FrmPrueba5
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Button btnMantenimientoProductos;
        private System.Windows.Forms.Button btnVerInventarioMateriaPrima;

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
            dgvInventario = new DataGridView();
            btnMantenimientoProductos = new Button();
            btnVerInventarioMateriaPrima = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            SuspendLayout();
            // 
            // dgvInventario
            // 
            dgvInventario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(26, 44);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.ReadOnly = true;
            dgvInventario.Size = new Size(934, 368);
            dgvInventario.TabIndex = 0;
            // 
            // btnMantenimientoProductos
            // 
            btnMantenimientoProductos.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnMantenimientoProductos.Location = new Point(760, 449);
            btnMantenimientoProductos.Name = "btnMantenimientoProductos";
            btnMantenimientoProductos.Size = new Size(200, 30);
            btnMantenimientoProductos.TabIndex = 1;
            btnMantenimientoProductos.Text = "Mantenimiento Productos";
            btnMantenimientoProductos.UseVisualStyleBackColor = true;
            btnMantenimientoProductos.Click += btnMantenimientoProductos_Click;
            // 
            // btnVerInventarioMateriaPrima
            // 
            btnVerInventarioMateriaPrima.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVerInventarioMateriaPrima.Location = new Point(530, 449);
            btnVerInventarioMateriaPrima.Name = "btnVerInventarioMateriaPrima";
            btnVerInventarioMateriaPrima.Size = new Size(200, 30);
            btnVerInventarioMateriaPrima.TabIndex = 2;
            btnVerInventarioMateriaPrima.Text = "Ver Inventario Materia Prima";
            btnVerInventarioMateriaPrima.UseVisualStyleBackColor = true;
            btnVerInventarioMateriaPrima.Click += btnVerInventarioMateriaPrima_Click;
            // 
            // FrmPrueba5
            // 
            BackColor = Color.FromArgb(37, 36, 81);
            ClientSize = new Size(989, 503);
            Controls.Add(btnVerInventarioMateriaPrima);
            Controls.Add(btnMantenimientoProductos);
            Controls.Add(dgvInventario);
            ForeColor = SystemColors.ControlText;
            Name = "FrmPrueba5";
            Text = "Inventario de Productos";
            Load += FrmPrueba5_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ResumeLayout(false);
        }
    }
}
