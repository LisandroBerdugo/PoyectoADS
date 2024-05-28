namespace Prueba2_Fase1
{
    partial class FrmPrueba6
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Button btnGenerarReporteCompras;
        private System.Windows.Forms.Button btnGenerarReporteVentas;
        private System.Windows.Forms.ProgressBar progressBar;

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
            this.btnGenerarReporteCompras = new System.Windows.Forms.Button();
            this.btnGenerarReporteVentas = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(12, 12);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(150, 23);
            this.btnGenerarReporte.TabIndex = 0;
            this.btnGenerarReporte.Text = "Generar Reporte Balance";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.BtnGenerarReporte_Click);
            // 
            // btnGenerarReporteCompras
            // 
            this.btnGenerarReporteCompras.Location = new System.Drawing.Point(12, 41);
            this.btnGenerarReporteCompras.Name = "btnGenerarReporteCompras";
            this.btnGenerarReporteCompras.Size = new System.Drawing.Size(150, 23);
            this.btnGenerarReporteCompras.TabIndex = 1;
            this.btnGenerarReporteCompras.Text = "Generar Reporte Compras";
            this.btnGenerarReporteCompras.UseVisualStyleBackColor = true;
            this.btnGenerarReporteCompras.Click += new System.EventHandler(this.BtnGenerarReporteCompras_Click);
            // 
            // btnGenerarReporteVentas
            // 
            this.btnGenerarReporteVentas.Location = new System.Drawing.Point(12, 70);
            this.btnGenerarReporteVentas.Name = "btnGenerarReporteVentas";
            this.btnGenerarReporteVentas.Size = new System.Drawing.Size(150, 23);
            this.btnGenerarReporteVentas.TabIndex = 2;
            this.btnGenerarReporteVentas.Text = "Generar Reporte Ventas";
            this.btnGenerarReporteVentas.UseVisualStyleBackColor = true;
            this.btnGenerarReporteVentas.Click += new System.EventHandler(this.BtnGenerarReporteVentas_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 100);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(260, 23);
            this.progressBar.TabIndex = 3;
            // 
            // FrmPrueba6
            // 
            this.ClientSize = new System.Drawing.Size(284, 136);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnGenerarReporteVentas);
            this.Controls.Add(this.btnGenerarReporteCompras);
            this.Controls.Add(this.btnGenerarReporte);
            this.Name = "FrmPrueba6";
            this.Text = "Generar Reportes";
            this.ResumeLayout(false);
        }
    }
}
