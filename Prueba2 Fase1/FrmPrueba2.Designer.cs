namespace Prueba2_Fase1
{
    partial class FrmPrueba2
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
            lblHasta = new Label();
            cbTodo = new CheckBox();
            lblDesde = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnAnular = new Button();
            btnVer = new Button();
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
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.ForeColor = SystemColors.ControlLightLight;
            lblHasta.Location = new Point(280, 71);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(40, 15);
            lblHasta.TabIndex = 21;
            lblHasta.Text = "Hasta:";
            // 
            // cbTodo
            // 
            cbTodo.AutoSize = true;
            cbTodo.ForeColor = SystemColors.ControlLightLight;
            cbTodo.Location = new Point(510, 65);
            cbTodo.Name = "cbTodo";
            cbTodo.Size = new Size(52, 19);
            cbTodo.TabIndex = 20;
            cbTodo.Text = "Todo";
            cbTodo.UseVisualStyleBackColor = true;
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.ForeColor = SystemColors.ControlLightLight;
            lblDesde.Location = new Point(51, 71);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(42, 15);
            lblDesde.TabIndex = 19;
            lblDesde.Text = "Desde:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(324, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(95, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 17;
            // 
            // btnAnular
            // 
            btnAnular.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnular.Location = new Point(703, 461);
            btnAnular.Name = "btnAnular";
            btnAnular.Size = new Size(75, 23);
            btnAnular.TabIndex = 16;
            btnAnular.Text = "Anular";
            btnAnular.UseVisualStyleBackColor = true;
            // 
            // btnVer
            // 
            btnVer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVer.Location = new Point(797, 461);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(75, 23);
            btnVer.TabIndex = 15;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
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
            // FrmPrueba2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 36, 81);
            ClientSize = new Size(989, 503);
            Controls.Add(lblHasta);
            Controls.Add(cbTodo);
            Controls.Add(lblDesde);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnAnular);
            Controls.Add(btnVer);
            Controls.Add(btnAgregar);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(dataGridView1);
            Name = "FrmPrueba2";
            Text = "MANTENIMIENTO DE COMPRAS";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHasta;
        private CheckBox cbTodo;
        private Label lblDesde;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnAnular;
        private Button btnVer;
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