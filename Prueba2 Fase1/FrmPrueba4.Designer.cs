namespace Prueba2_Fase1
{
    partial class FrmClientes
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
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            username = new DataGridViewTextBoxColumn();
            enabled = new DataGridViewTextBoxColumn();
            verified = new DataGridViewTextBoxColumn();
            rol = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminar.Location = new Point(703, 461);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditar.Location = new Point(797, 461);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAgregar.Location = new Point(881, 461);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(33, 19);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(529, 23);
            txtBuscar.TabIndex = 13;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(568, 18);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 24);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, username, enabled, verified, rol });
            dataGridView1.Location = new Point(33, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(923, 335);
            dataGridView1.TabIndex = 11;
            // 
            // id
            // 
            id.Frozen = true;
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // username
            // 
            username.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            username.HeaderText = "usuario";
            username.MinimumWidth = 100;
            username.Name = "username";
            username.ReadOnly = true;
            // 
            // enabled
            // 
            enabled.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            enabled.FillWeight = 75F;
            enabled.HeaderText = "habilitado";
            enabled.MinimumWidth = 75;
            enabled.Name = "enabled";
            enabled.ReadOnly = true;
            // 
            // verified
            // 
            verified.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            verified.FillWeight = 75F;
            verified.HeaderText = "verificado";
            verified.MinimumWidth = 75;
            verified.Name = "verified";
            verified.ReadOnly = true;
            // 
            // rol
            // 
            rol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            rol.HeaderText = "rol";
            rol.MinimumWidth = 75;
            rol.Name = "rol";
            rol.ReadOnly = true;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 36, 81);
            ClientSize = new Size(989, 503);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(dataGridView1);
            Name = "FrmClientes";
            Text = "MANTENIMIENTO CLIENTES";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn enabled;
        private DataGridViewTextBoxColumn verified;
        private DataGridViewTextBoxColumn rol;
    }
}