namespace Prueba2_Fase1
{
    partial class frmSeleccionarCliente
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
            btnSeleccionar = new Button();
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
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.Location = new Point(615, 389);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 32;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSeleccionar.Location = new Point(699, 389);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(75, 23);
            btnSeleccionar.TabIndex = 31;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(84, 39);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(529, 23);
            txtBuscar.TabIndex = 30;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(651, 39);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 24);
            btnBuscar.TabIndex = 29;
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
            dataGridView1.Location = new Point(21, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(758, 262);
            dataGridView1.TabIndex = 28;
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
            // frmSeleccionarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnSeleccionar);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(dataGridView1);
            Name = "frmSeleccionarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSeleccionarCliente";
            Load += frmSeleccionarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnSeleccionar;
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