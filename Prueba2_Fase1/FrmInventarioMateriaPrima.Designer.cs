namespace Prueba2_Fase1
{
    partial class FrmInventarioMateriaPrima
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvInventarioMateriaPrima;

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
            this.dgvInventarioMateriaPrima = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioMateriaPrima)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInventarioMateriaPrima
            // 
            this.dgvInventarioMateriaPrima.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right));
            this.dgvInventarioMateriaPrima.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventarioMateriaPrima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventarioMateriaPrima.Location = new System.Drawing.Point(12, 12);
            this.dgvInventarioMateriaPrima.Name = "dgvInventarioMateriaPrima";
            this.dgvInventarioMateriaPrima.ReadOnly = true;
            this.dgvInventarioMateriaPrima.Size = new System.Drawing.Size(760, 437);
            this.dgvInventarioMateriaPrima.TabIndex = 0;
            // 
            // FrmInventarioMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dgvInventarioMateriaPrima);
            this.Name = "FrmInventarioMateriaPrima";
            this.Text = "Inventario de Materia Prima";
            this.Load += new System.EventHandler(this.FrmInventarioMateriaPrima_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioMateriaPrima)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
