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
            btnGenerarReporte = new Button();
            btnGenerarReporteCompras = new Button();
            btnGenerarReporteVentas = new Button();
            progressBar = new ProgressBar();
            SuspendLayout();
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.Anchor = AnchorStyles.None;
            btnGenerarReporte.Location = new Point(116, 120);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(193, 279);
            btnGenerarReporte.TabIndex = 0;
            btnGenerarReporte.Text = "Generar Reporte Balance";
            btnGenerarReporte.UseVisualStyleBackColor = true;
            btnGenerarReporte.Click += BtnGenerarReporte_Click;
            // 
            // btnGenerarReporteCompras
            // 
            btnGenerarReporteCompras.Anchor = AnchorStyles.None;
            btnGenerarReporteCompras.Location = new Point(390, 120);
            btnGenerarReporteCompras.Name = "btnGenerarReporteCompras";
            btnGenerarReporteCompras.Size = new Size(197, 279);
            btnGenerarReporteCompras.TabIndex = 1;
            btnGenerarReporteCompras.Text = "Generar Reporte Compras";
            btnGenerarReporteCompras.UseVisualStyleBackColor = true;
            btnGenerarReporteCompras.Click += BtnGenerarReporteCompras_Click;
            // 
            // btnGenerarReporteVentas
            // 
            btnGenerarReporteVentas.Anchor = AnchorStyles.None;
            btnGenerarReporteVentas.Location = new Point(679, 120);
            btnGenerarReporteVentas.Name = "btnGenerarReporteVentas";
            btnGenerarReporteVentas.Size = new Size(195, 279);
            btnGenerarReporteVentas.TabIndex = 2;
            btnGenerarReporteVentas.Text = "Generar Reporte Ventas";
            btnGenerarReporteVentas.UseVisualStyleBackColor = true;
            btnGenerarReporteVentas.Click += BtnGenerarReporteVentas_Click;
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            progressBar.Location = new Point(707, 27);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(260, 23);
            progressBar.TabIndex = 3;
            // 
            // FrmPrueba6
            // 
            BackColor = Color.FromArgb(37, 36, 81);
            ClientSize = new Size(989, 503);
            Controls.Add(progressBar);
            Controls.Add(btnGenerarReporteVentas);
            Controls.Add(btnGenerarReporteCompras);
            Controls.Add(btnGenerarReporte);
            Name = "FrmPrueba6";
            Text = "Generar Reportes";
            ResumeLayout(false);
        }
    }
}
