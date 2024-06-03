namespace Prueba2_Fase1
{
    partial class frmMantenimientoProductos
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnEditarProducto;

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
            textBoxBuscar = new TextBox();
            labelBuscar = new Label();
            dataGridViewProductos = new DataGridView();
            btnAgregarProducto = new Button();
            btnEditarProducto = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            SuspendLayout();
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(83, 21);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(593, 23);
            textBoxBuscar.TabIndex = 0;
            textBoxBuscar.TextChanged += textBoxBuscar_TextChanged;
            // 
            // labelBuscar
            // 
            labelBuscar.AutoSize = true;
            labelBuscar.Location = new Point(24, 23);
            labelBuscar.Name = "labelBuscar";
            labelBuscar.Size = new Size(45, 15);
            labelBuscar.TabIndex = 1;
            labelBuscar.Text = "Buscar:";
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Location = new Point(26, 61);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.RowTemplate.Height = 24;
            dataGridViewProductos.Size = new Size(649, 350);
            dataGridViewProductos.TabIndex = 2;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(26, 422);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(131, 28);
            btnAgregarProducto.TabIndex = 3;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.Location = new Point(175, 422);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(131, 28);
            btnEditarProducto.TabIndex = 4;
            btnEditarProducto.Text = "Editar Producto";
            btnEditarProducto.UseVisualStyleBackColor = true;
            btnEditarProducto.Click += btnEditarProducto_Click;
            // 
            // frmMantenimientoProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 469);
            Controls.Add(btnEditarProducto);
            Controls.Add(btnAgregarProducto);
            Controls.Add(dataGridViewProductos);
            Controls.Add(labelBuscar);
            Controls.Add(textBoxBuscar);
            MaximizeBox = false;
            MaximumSize = new Size(716, 508);
            MinimumSize = new Size(716, 508);
            Name = "frmMantenimientoProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Productos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
