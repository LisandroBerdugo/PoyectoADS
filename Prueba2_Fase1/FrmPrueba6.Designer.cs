namespace Prueba2_Fase1
{
    partial class FrmPrueba6
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Button btnGenerarReporteCompras;
        private System.Windows.Forms.Button btnGenerarReporteVentas;
        private System.Windows.Forms.Button btnGenerarReporteCreacionJuguetes;
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
            btnGenerarReporte = new System.Windows.Forms.Button();
            btnGenerarReporteCompras = new System.Windows.Forms.Button();
            btnGenerarReporteVentas = new System.Windows.Forms.Button();
            btnGenerarReporteCreacionJuguetes = new System.Windows.Forms.Button();
            progressBar = new System.Windows.Forms.ProgressBar();
            SuspendLayout();
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnGenerarReporte.Location = new System.Drawing.Point(20, 120);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new System.Drawing.Size(150, 50);
            btnGenerarReporte.TabIndex = 0;
            btnGenerarReporte.Text = "Generar Reporte Balance";
            btnGenerarReporte.UseVisualStyleBackColor = true;
            btnGenerarReporte.Click += new System.EventHandler(BtnGenerarReporte_Click);
            // 
            // btnGenerarReporteCompras
            // 
            btnGenerarReporteCompras.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnGenerarReporteCompras.Location = new System.Drawing.Point(200, 120);
            btnGenerarReporteCompras.Name = "btnGenerarReporteCompras";
            btnGenerarReporteCompras.Size = new System.Drawing.Size(150, 50);
            btnGenerarReporteCompras.TabIndex = 1;
            btnGenerarReporteCompras.Text = "Generar Reporte Compras";
            btnGenerarReporteCompras.UseVisualStyleBackColor = true;
            btnGenerarReporteCompras.Click += new System.EventHandler(BtnGenerarReporteCompras_Click);
            // 
            // btnGenerarReporteVentas
            // 
            btnGenerarReporteVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnGenerarReporteVentas.Location = new System.Drawing.Point(380, 120);
            btnGenerarReporteVentas.Name = "btnGenerarReporteVentas";
            btnGenerarReporteVentas.Size = new System.Drawing.Size(150, 50);
            btnGenerarReporteVentas.TabIndex = 2;
            btnGenerarReporteVentas.Text = "Generar Reporte Ventas";
            btnGenerarReporteVentas.UseVisualStyleBackColor = true;
            btnGenerarReporteVentas.Click += new System.EventHandler(BtnGenerarReporteVentas_Click);
            // 
            // btnGenerarReporteCreacionJuguetes
            // 
            btnGenerarReporteCreacionJuguetes.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnGenerarReporteCreacionJuguetes.Location = new System.Drawing.Point(560, 120);
            btnGenerarReporteCreacionJuguetes.Name = "btnGenerarReporteCreacionJuguetes";
            btnGenerarReporteCreacionJuguetes.Size = new System.Drawing.Size(150, 50);
            btnGenerarReporteCreacionJuguetes.TabIndex = 3;
            btnGenerarReporteCreacionJuguetes.Text = "Generar Reporte Creación Juguetes";
            btnGenerarReporteCreacionJuguetes.UseVisualStyleBackColor = true;
            btnGenerarReporteCreacionJuguetes.Click += new System.EventHandler(BtnGenerarReporteCreacionJuguetes_Click);
            // 
            // progressBar
            // 
            progressBar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            progressBar.Location = new System.Drawing.Point(20, 20);
            progressBar.Name = "progressBar";
            progressBar.Size = new System.Drawing.Size(690, 23);
            progressBar.TabIndex = 4;
            // 
            // FrmPrueba6
            // 
            BackColor = System.Drawing.Color.FromArgb(37, 36, 81);
            ClientSize = new System.Drawing.Size(734, 261);
            Controls.Add(progressBar);
            Controls.Add(btnGenerarReporteCreacionJuguetes);
            Controls.Add(btnGenerarReporteVentas);
            Controls.Add(btnGenerarReporteCompras);
            Controls.Add(btnGenerarReporte);
            Name = "FrmPrueba6";
            Text = "Generar Reportes";
            ResumeLayout(false);
        }
    }
}
