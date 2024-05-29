namespace Prueba2_Fase1
{
    partial class FormaMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaMenu));
            panelMenu = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btn6 = new FontAwesome.Sharp.IconButton();
            btn5 = new FontAwesome.Sharp.IconButton();
            btn4 = new FontAwesome.Sharp.IconButton();
            btn3 = new FontAwesome.Sharp.IconButton();
            btn2 = new FontAwesome.Sharp.IconButton();
            btn1 = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnHome = new PictureBox();
            panelTitleBar = new Panel();
            btnMinimizar = new FontAwesome.Sharp.IconPictureBox();
            btnMaximizar = new FontAwesome.Sharp.IconPictureBox();
            btnExit = new FontAwesome.Sharp.IconPictureBox();
            lblHome = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelSombra = new Panel();
            pnlDesktop = new Panel();
            lblFecha = new Label();
            lblHora = new Label();
            pictureBox1 = new PictureBox();
            horafecha = new System.Windows.Forms.Timer(components);
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            pnlDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 0, 64);
            panelMenu.Controls.Add(iconButton1);
            panelMenu.Controls.Add(btn6);
            panelMenu.Controls.Add(btn5);
            panelMenu.Controls.Add(btn4);
            panelMenu.Controls.Add(btn3);
            panelMenu.Controls.Add(btn2);
            panelMenu.Controls.Add(btn1);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 626);
            panelMenu.TabIndex = 0;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.OrangeRed;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserSlash;
            iconButton1.IconColor = Color.OrangeRed;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 46;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(-3, 566);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(10, 0, 20, 0);
            iconButton1.Size = new Size(220, 60);
            iconButton1.TabIndex = 7;
            iconButton1.Text = "Cerrar Sesion";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btn6
            // 
            btn6.Cursor = Cursors.Hand;
            btn6.Dock = DockStyle.Top;
            btn6.FlatAppearance.BorderSize = 0;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.ForeColor = SystemColors.Window;
            btn6.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            btn6.IconColor = SystemColors.Window;
            btn6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn6.IconSize = 46;
            btn6.ImageAlign = ContentAlignment.MiddleLeft;
            btn6.Location = new Point(0, 440);
            btn6.Name = "btn6";
            btn6.Padding = new Padding(10, 0, 20, 0);
            btn6.Size = new Size(220, 60);
            btn6.TabIndex = 6;
            btn6.Text = "Reportes";
            btn6.TextAlign = ContentAlignment.MiddleLeft;
            btn6.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Cursor = Cursors.Hand;
            btn5.Dock = DockStyle.Top;
            btn5.FlatAppearance.BorderSize = 0;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.ForeColor = SystemColors.Window;
            btn5.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            btn5.IconColor = SystemColors.Window;
            btn5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn5.IconSize = 46;
            btn5.ImageAlign = ContentAlignment.MiddleLeft;
            btn5.Location = new Point(0, 380);
            btn5.Name = "btn5";
            btn5.Padding = new Padding(10, 0, 20, 0);
            btn5.Size = new Size(220, 60);
            btn5.TabIndex = 5;
            btn5.Text = "Productos";
            btn5.TextAlign = ContentAlignment.MiddleLeft;
            btn5.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Cursor = Cursors.Hand;
            btn4.Dock = DockStyle.Top;
            btn4.FlatAppearance.BorderSize = 0;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.ForeColor = SystemColors.Window;
            btn4.IconChar = FontAwesome.Sharp.IconChar.UsersLine;
            btn4.IconColor = SystemColors.Window;
            btn4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn4.IconSize = 46;
            btn4.ImageAlign = ContentAlignment.MiddleLeft;
            btn4.Location = new Point(0, 320);
            btn4.Name = "btn4";
            btn4.Padding = new Padding(10, 0, 20, 0);
            btn4.Size = new Size(220, 60);
            btn4.TabIndex = 4;
            btn4.Text = "Clientes";
            btn4.TextAlign = ContentAlignment.MiddleLeft;
            btn4.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.Cursor = Cursors.Hand;
            btn3.Dock = DockStyle.Top;
            btn3.FlatAppearance.BorderSize = 0;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.ForeColor = SystemColors.Window;
            btn3.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            btn3.IconColor = SystemColors.Window;
            btn3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn3.IconSize = 46;
            btn3.ImageAlign = ContentAlignment.MiddleLeft;
            btn3.Location = new Point(0, 260);
            btn3.Name = "btn3";
            btn3.Padding = new Padding(10, 0, 20, 0);
            btn3.Size = new Size(220, 60);
            btn3.TabIndex = 3;
            btn3.Text = "Ventas";
            btn3.TextAlign = ContentAlignment.MiddleLeft;
            btn3.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Cursor = Cursors.Hand;
            btn2.Dock = DockStyle.Top;
            btn2.FlatAppearance.BorderSize = 0;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.ForeColor = SystemColors.Window;
            btn2.IconChar = FontAwesome.Sharp.IconChar.Shop;
            btn2.IconColor = SystemColors.Window;
            btn2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn2.IconSize = 46;
            btn2.ImageAlign = ContentAlignment.MiddleLeft;
            btn2.Location = new Point(0, 200);
            btn2.Name = "btn2";
            btn2.Padding = new Padding(10, 0, 20, 0);
            btn2.Size = new Size(220, 60);
            btn2.TabIndex = 2;
            btn2.Text = "Compras";
            btn2.TextAlign = ContentAlignment.MiddleLeft;
            btn2.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Cursor = Cursors.HSplit;
            btn1.Dock = DockStyle.Top;
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.ForeColor = SystemColors.Window;
            btn1.IconChar = FontAwesome.Sharp.IconChar.Users;
            btn1.IconColor = SystemColors.Window;
            btn1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn1.IconSize = 46;
            btn1.ImageAlign = ContentAlignment.MiddleLeft;
            btn1.Location = new Point(0, 140);
            btn1.Name = "btn1";
            btn1.Padding = new Padding(10, 0, 20, 0);
            btn1.Size = new Size(220, 60);
            btn1.TabIndex = 1;
            btn1.Text = "Usuarios";
            btn1.TextAlign = ContentAlignment.MiddleLeft;
            btn1.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(btnHome);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 140);
            panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(21, 12);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(176, 106);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 0, 64);
            panelTitleBar.Controls.Add(btnMinimizar);
            panelTitleBar.Controls.Add(btnMaximizar);
            panelTitleBar.Controls.Add(btnExit);
            panelTitleBar.Controls.Add(lblHome);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1005, 75);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.BackColor = Color.Transparent;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.ForeColor = SystemColors.ControlLightLight;
            btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimizar.IconColor = SystemColors.ControlLightLight;
            btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimizar.Location = new Point(880, 21);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(32, 32);
            btnMinimizar.TabIndex = 4;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.BackColor = Color.Transparent;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.ForeColor = SystemColors.ControlLightLight;
            btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            btnMaximizar.IconColor = SystemColors.ControlLightLight;
            btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximizar.Location = new Point(918, 21);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(32, 32);
            btnMaximizar.TabIndex = 3;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.Transparent;
            btnExit.Cursor = Cursors.Hand;
            btnExit.ForeColor = SystemColors.ControlLightLight;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            btnExit.IconColor = SystemColors.ControlLightLight;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.Location = new Point(956, 21);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(32, 32);
            btnExit.TabIndex = 2;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblHome
            // 
            lblHome.AutoSize = true;
            lblHome.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblHome.ForeColor = SystemColors.ControlLightLight;
            lblHome.Location = new Point(58, 21);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(78, 32);
            lblHome.TabIndex = 1;
            lblHome.Text = "Inicio";
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(0, 0, 64);
            iconCurrentChildForm.ForeColor = Color.DarkViolet;
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HomeLgAlt;
            iconCurrentChildForm.IconColor = Color.DarkViolet;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.Location = new Point(23, 21);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(32, 32);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // panelSombra
            // 
            panelSombra.BackColor = Color.FromArgb(26, 24, 58);
            panelSombra.Dock = DockStyle.Top;
            panelSombra.Location = new Point(220, 75);
            panelSombra.Name = "panelSombra";
            panelSombra.Size = new Size(1005, 9);
            panelSombra.TabIndex = 2;
            // 
            // pnlDesktop
            // 
            pnlDesktop.BackColor = Color.FromArgb(0, 0, 64);
            pnlDesktop.Controls.Add(lblFecha);
            pnlDesktop.Controls.Add(lblHora);
            pnlDesktop.Controls.Add(pictureBox1);
            pnlDesktop.Dock = DockStyle.Fill;
            pnlDesktop.Location = new Point(220, 84);
            pnlDesktop.Name = "pnlDesktop";
            pnlDesktop.Size = new Size(1005, 542);
            pnlDesktop.TabIndex = 3;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.ForeColor = SystemColors.ControlLightLight;
            lblFecha.Location = new Point(6, 3);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(215, 65);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "lblFecha";
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHora.AutoSize = true;
            lblHora.BackColor = Color.Transparent;
            lblHora.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHora.ForeColor = SystemColors.ControlLightLight;
            lblHora.Location = new Point(805, 3);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(197, 65);
            lblHora.TabIndex = 2;
            lblHora.Text = "lblHora";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(194, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(605, 523);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // horafecha
            // 
            horafecha.Enabled = true;
            horafecha.Tick += horafecha_Tick;
            // 
            // FormaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1225, 626);
            Controls.Add(pnlDesktop);
            Controls.Add(panelSombra);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1241, 665);
            Name = "FormaMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormaMenu_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            pnlDesktop.ResumeLayout(false);
            pnlDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btn1;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btn6;
        private FontAwesome.Sharp.IconButton btn5;
        private FontAwesome.Sharp.IconButton btn4;
        private FontAwesome.Sharp.IconButton btn3;
        private FontAwesome.Sharp.IconButton btn2;
        private PictureBox btnHome;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Label lblHome;
        private Panel panelSombra;
        private Panel pnlDesktop;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox btnMaximizar;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private FontAwesome.Sharp.IconPictureBox btnMinimizar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label lblFecha;
        private Label lblHora;
        private System.Windows.Forms.Timer horafecha;
    }
}
