namespace Prueba2_Fase1
{
    partial class FrmPrueba6
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnGenerarReporte;

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
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(12, 12);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(150, 23);
            this.btnGenerarReporte.TabIndex = 0;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.BtnGenerarReporte_Click);
            // 
            // FrmPrueba6
            // 
            this.ClientSize = new System.Drawing.Size(284, 61);
            this.Controls.Add(this.btnGenerarReporte);
            this.Name = "FrmPrueba6";
            this.Text = "Generar Reporte de Balance";
            this.ResumeLayout(false);
        }
    }
}
