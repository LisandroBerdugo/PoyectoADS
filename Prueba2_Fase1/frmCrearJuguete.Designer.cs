namespace Prueba2_Fase1
{
    partial class frmCrearJuguete
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.Label labelCantidad;

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
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnCrear = new System.Windows.Forms.Button();
            this.labelProducto = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 

            // cbProducto
            // 
            this.cbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(100, 20);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(200, 23);
            this.cbProducto.TabIndex = 0;
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(100, 60);
            this.numCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 23);
            this.numCantidad.TabIndex = 1;
            this.numCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(100, 100);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(100, 30);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.Location = new System.Drawing.Point(20, 20);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(59, 15);
            this.labelProducto.TabIndex = 3;
            this.labelProducto.Text = "Producto:";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(20, 60);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(59, 15);
            this.labelCantidad.TabIndex = 4;
            this.labelCantidad.Text = "Cantidad:";
            // 
            // frmCrearJuguete
            // 
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.labelProducto);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.cbProducto);
            this.Name = "frmCrearJuguete";
            this.Text = "Crear Juguete";
            this.Load += new System.EventHandler(this.frmCrearJuguete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
