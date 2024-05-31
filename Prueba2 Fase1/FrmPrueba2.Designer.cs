namespace Prueba2_Fase1
{
    partial class FrmPrueba2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAbrirFrmCompras;
        private System.Windows.Forms.Button btnVerDetalles;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;

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
            dgvCompras = new DataGridView();
            txtFiltro = new TextBox();
            btnBuscar = new Button();
            btnAbrirFrmCompras = new Button();
            btnVerDetalles = new Button();
            dtpFechaInicio = new DateTimePicker();
            dtpFechaFin = new DateTimePicker();
            lblFechaInicio = new Label();
            lblFechaFin = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
            SuspendLayout();
            // 
            // dgvCompras
            // 
            dgvCompras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompras.Location = new Point(21, 65);
            dgvCompras.Name = "dgvCompras";
            dgvCompras.RowHeadersVisible = false;
            dgvCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompras.Size = new Size(941, 360);
            dgvCompras.TabIndex = 0;
            dgvCompras.SelectionChanged += dgvCompras_SelectionChanged;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(21, 23);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(200, 23);
            txtFiltro.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(817, 22);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAbrirFrmCompras
            // 
            btnAbrirFrmCompras.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAbrirFrmCompras.Location = new Point(31, 456);
            btnAbrirFrmCompras.Name = "btnAbrirFrmCompras";
            btnAbrirFrmCompras.Size = new Size(128, 23);
            btnAbrirFrmCompras.TabIndex = 7;
            btnAbrirFrmCompras.Text = "Realizar Compra";
            btnAbrirFrmCompras.UseVisualStyleBackColor = true;
            btnAbrirFrmCompras.Click += BtnAbrirFrmCompras_Click;
            // 
            // btnVerDetalles
            // 
            btnVerDetalles.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVerDetalles.Enabled = false;
            btnVerDetalles.Location = new Point(194, 456);
            btnVerDetalles.Name = "btnVerDetalles";
            btnVerDetalles.Size = new Size(105, 23);
            btnVerDetalles.TabIndex = 8;
            btnVerDetalles.Text = "Ver Detalles";
            btnVerDetalles.UseVisualStyleBackColor = true;
            btnVerDetalles.Click += BtnVerDetalles_Click;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(287, 23);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(211, 23);
            dtpFechaInicio.TabIndex = 3;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Location = new Point(570, 23);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(218, 23);
            dtpFechaFin.TabIndex = 4;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.ForeColor = Color.White;
            lblFechaInicio.Location = new Point(237, 26);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(42, 15);
            lblFechaInicio.TabIndex = 5;
            lblFechaInicio.Text = "Desde:";
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.ForeColor = Color.White;
            lblFechaFin.Location = new Point(524, 26);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(40, 15);
            lblFechaFin.TabIndex = 6;
            lblFechaFin.Text = "Hasta:";
            // 
            // FrmPrueba2
            // 
            BackColor = Color.FromArgb(37, 36, 81);
            ClientSize = new Size(989, 503);
            Controls.Add(btnVerDetalles);
            Controls.Add(btnAbrirFrmCompras);
            Controls.Add(lblFechaFin);
            Controls.Add(lblFechaInicio);
            Controls.Add(dtpFechaFin);
            Controls.Add(dtpFechaInicio);
            Controls.Add(btnBuscar);
            Controls.Add(txtFiltro);
            Controls.Add(dgvCompras);
            Name = "FrmPrueba2";
            Text = "Compras Realizadas";
            Load += FrmPrueba2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
