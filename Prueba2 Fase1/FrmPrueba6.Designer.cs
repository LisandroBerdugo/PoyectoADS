namespace Prueba2_Fase1
{
    partial class FrmPrueba6
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
            lblDesde = new Label();
            lblHasta = new Label();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // lblDesde
            // 
            lblDesde.Anchor = AnchorStyles.None;
            lblDesde.AutoSize = true;
            lblDesde.ForeColor = SystemColors.ControlLightLight;
            lblDesde.Location = new Point(182, 74);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(42, 15);
            lblDesde.TabIndex = 0;
            lblDesde.Text = "Desde:";
            // 
            // lblHasta
            // 
            lblHasta.Anchor = AnchorStyles.None;
            lblHasta.AutoSize = true;
            lblHasta.ForeColor = SystemColors.ControlLightLight;
            lblHasta.Location = new Point(423, 74);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(40, 15);
            lblHasta.TabIndex = 1;
            lblHasta.Text = "Hasta:";
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.None;
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = SystemColors.ControlLightLight;
            checkBox1.Location = new Point(647, 71);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(52, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Todo";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(231, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(467, 69);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(88, 172);
            button1.Name = "button1";
            button1.Size = new Size(164, 227);
            button1.TabIndex = 5;
            button1.Text = "REPORTE DE COMPRAS";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(306, 172);
            button2.Name = "button2";
            button2.Size = new Size(157, 227);
            button2.TabIndex = 6;
            button2.Text = "REPORTE DE VENTAS";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Location = new Point(520, 172);
            button3.Name = "button3";
            button3.Size = new Size(158, 227);
            button3.TabIndex = 7;
            button3.Text = "BALANCE";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Location = new Point(731, 172);
            button4.Name = "button4";
            button4.Size = new Size(158, 227);
            button4.TabIndex = 8;
            button4.Text = "INVENTARIO";
            button4.UseVisualStyleBackColor = true;
            // 
            // FrmPrueba6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 36, 81);
            ClientSize = new Size(989, 503);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(checkBox1);
            Controls.Add(lblHasta);
            Controls.Add(lblDesde);
            Name = "FrmPrueba6";
            Text = "GENERAR REPORTES";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDesde;
        private Label lblHasta;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}