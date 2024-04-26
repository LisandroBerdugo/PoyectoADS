namespace Prueba2_Fase1
{
    partial class frmSeleccionarProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCancelar = new Button();
            btnGuardar = new Button();
            btnRegistarProd = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(566, 387);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(681, 387);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 26;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnRegistarProd
            // 
            btnRegistarProd.Location = new Point(45, 344);
            btnRegistarProd.Name = "btnRegistarProd";
            btnRegistarProd.Size = new Size(132, 23);
            btnRegistarProd.TabIndex = 25;
            btnRegistarProd.Text = "Registrar Producto";
            btnRegistarProd.UseVisualStyleBackColor = true;
            btnRegistarProd.Click += btnRegistarProd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(45, 99);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(711, 239);
            dataGridView1.TabIndex = 22;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(115, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(526, 23);
            textBox1.TabIndex = 20;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(662, 50);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 29;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // frmSeleccionarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(btnRegistarProd);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "frmSeleccionarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSeleccionarProducto";
            Load += frmSeleccionarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnRegistarProd;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button btnBuscar;
    }
}