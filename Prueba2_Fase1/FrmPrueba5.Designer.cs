namespace Prueba2_Fase1
{
    partial class FrmPrueba5
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Button btnMantenimientoProductos;
        private System.Windows.Forms.Button btnVerInventarioMateriaPrima;
        private System.Windows.Forms.Button btnCrearJuguete;

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
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.btnMantenimientoProductos = new System.Windows.Forms.Button();
            this.btnVerInventarioMateriaPrima = new System.Windows.Forms.Button();
            this.btnCrearJuguete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInventario
            // 
            this.dgvInventario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right));
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(26, 44);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.Size = new System.Drawing.Size(934, 368);
            this.dgvInventario.TabIndex = 0;
            // 
            // btnMantenimientoProductos
            // 
            this.btnMantenimientoProductos.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnMantenimientoProductos.Location = new System.Drawing.Point(760, 449);
            this.btnMantenimientoProductos.Name = "btnMantenimientoProductos";
            this.btnMantenimientoProductos.Size = new System.Drawing.Size(200, 30);
            this.btnMantenimientoProductos.TabIndex = 1;
            this.btnMantenimientoProductos.Text = "Mantenimiento Productos";
            this.btnMantenimientoProductos.UseVisualStyleBackColor = true;
            this.btnMantenimientoProductos.Click += new System.EventHandler(this.btnMantenimientoProductos_Click);
            // 
            // btnVerInventarioMateriaPrima
            // 
            this.btnVerInventarioMateriaPrima.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnVerInventarioMateriaPrima.Location = new System.Drawing.Point(530, 449);
            this.btnVerInventarioMateriaPrima.Name = "btnVerInventarioMateriaPrima";
            this.btnVerInventarioMateriaPrima.Size = new System.Drawing.Size(200, 30);
            this.btnVerInventarioMateriaPrima.TabIndex = 2;
            this.btnVerInventarioMateriaPrima.Text = "Ver Inventario Materia Prima";
            this.btnVerInventarioMateriaPrima.UseVisualStyleBackColor = true;
            this.btnVerInventarioMateriaPrima.Click += new System.EventHandler(this.btnVerInventarioMateriaPrima_Click);
            // 
            // btnCrearJuguete
            // 
            this.btnCrearJuguete.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnCrearJuguete.Location = new System.Drawing.Point(300, 449);
            this.btnCrearJuguete.Name = "btnCrearJuguete";
            this.btnCrearJuguete.Size = new System.Drawing.Size(200, 30);
            this.btnCrearJuguete.TabIndex = 3;
            this.btnCrearJuguete.Text = "Crear Juguete";
            this.btnCrearJuguete.UseVisualStyleBackColor = true;
            this.btnCrearJuguete.Click += new System.EventHandler(this.btnCrearJuguete_Click);
            // 
            // FrmPrueba5
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(989, 503);
            this.Controls.Add(this.btnCrearJuguete);
            this.Controls.Add(this.btnVerInventarioMateriaPrima);
            this.Controls.Add(this.btnMantenimientoProductos);
            this.Controls.Add(this.dgvInventario);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmPrueba5";
            this.Text = "Inventario de Productos";
            this.Load += new System.EventHandler(this.FrmPrueba5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
