namespace Prueba2_Fase1
{
    partial class frmSeleccionarMateriaPrima
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvMateriaPrima;
        private System.Windows.Forms.DataGridView dgvSeleccionadas;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Button btnAceptar;

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
            this.dgvMateriaPrima = new System.Windows.Forms.DataGridView();
            this.dgvSeleccionadas = new System.Windows.Forms.DataGridView();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriaPrima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMateriaPrima
            // 
            this.dgvMateriaPrima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriaPrima.Location = new System.Drawing.Point(12, 12);
            this.dgvMateriaPrima.Name = "dgvMateriaPrima";
            this.dgvMateriaPrima.Size = new System.Drawing.Size(240, 150);
            this.dgvMateriaPrima.TabIndex = 0;
            // 
            // dgvSeleccionadas
            // 
            this.dgvSeleccionadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeleccionadas.Location = new System.Drawing.Point(12, 180);
            this.dgvSeleccionadas.Name = "dgvSeleccionadas";
            this.dgvSeleccionadas.Size = new System.Drawing.Size(240, 150);
            this.dgvSeleccionadas.TabIndex = 1;
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(12, 336);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 20);
            this.numCantidad.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(177, 336);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmSeleccionarMateriaPrima
            // 
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.dgvSeleccionadas);
            this.Controls.Add(this.dgvMateriaPrima);
            this.Name = "frmSeleccionarMateriaPrima";
            this.Load += new System.EventHandler(this.frmSeleccionarMateriaPrima_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriaPrima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
