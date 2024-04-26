namespace Prueba2_Fase1
{
    partial class FrmUsuarios
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
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            username = new DataGridViewTextBoxColumn();
            enabled = new DataGridViewTextBoxColumn();
            verified = new DataGridViewTextBoxColumn();
            rol = new DataGridViewTextBoxColumn();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            btnAgregar = new Button();
            btnVer = new Button();
            btnAnular = new Button();
            cbHabilitado = new CheckBox();
            cbVerificado = new CheckBox();
            cmbRol = new ComboBox();
            lblRol = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, username, enabled, verified, rol });
            dataGridView1.Location = new Point(32, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(923, 335);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // btnBuscar
            // 
            btnBuscar.Location = new Point(567, 12);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 24);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(32, 13);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(529, 23);
            txtBuscar.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAgregar.Location = new Point(880, 455);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnVer
            // 
            btnVer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVer.Location = new Point(796, 455);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(75, 23);
            btnVer.TabIndex = 4;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
            // 
            // btnAnular
            // 
            btnAnular.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnular.Location = new Point(702, 455);
            btnAnular.Name = "btnAnular";
            btnAnular.Size = new Size(75, 23);
            btnAnular.TabIndex = 5;
            btnAnular.Text = "Anular";
            btnAnular.UseVisualStyleBackColor = true;
            // 
            // cbHabilitado
            // 
            cbHabilitado.AutoSize = true;
            cbHabilitado.ForeColor = SystemColors.ControlLightLight;
            cbHabilitado.Location = new Point(57, 57);
            cbHabilitado.Name = "cbHabilitado";
            cbHabilitado.Size = new Size(81, 19);
            cbHabilitado.TabIndex = 13;
            cbHabilitado.Text = "Habilitado";
            cbHabilitado.UseVisualStyleBackColor = true;
            // 
            // cbVerificado
            // 
            cbVerificado.AutoSize = true;
            cbVerificado.ForeColor = SystemColors.ControlLightLight;
            cbVerificado.Location = new Point(239, 57);
            cbVerificado.Name = "cbVerificado";
            cbVerificado.Size = new Size(78, 19);
            cbVerificado.TabIndex = 14;
            cbVerificado.Text = "Verificado";
            cbVerificado.UseVisualStyleBackColor = true;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(440, 53);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(121, 23);
            cmbRol.TabIndex = 15;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.ForeColor = SystemColors.ControlLightLight;
            lblRol.Location = new Point(407, 58);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(27, 15);
            lblRol.TabIndex = 16;
            lblRol.Text = "Rol:";
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 36, 81);
            ClientSize = new Size(989, 503);
            Controls.Add(lblRol);
            Controls.Add(cmbRol);
            Controls.Add(cbVerificado);
            Controls.Add(cbHabilitado);
            Controls.Add(btnAnular);
            Controls.Add(btnVer);
            Controls.Add(btnAgregar);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(dataGridView1);
            Name = "FrmUsuarios";
            Text = "MANTENIMIENTO DE USUARIOS";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Button btnAgregar;
        private Button btnVer;
        private Button btnAnular;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn enabled;
        private DataGridViewTextBoxColumn verified;
        private DataGridViewTextBoxColumn rol;
        private CheckBox cbHabilitado;
        private CheckBox cbVerificado;
        private ComboBox cmbRol;
        private Label lblRol;
    }
}