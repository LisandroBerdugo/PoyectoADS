﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba2_Fase1
{
    public partial class frmSeleccionarProveedor : Form
    {
        public frmSeleccionarProveedor()
        {
            InitializeComponent();

            this.MaximizeBox = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSeleccionarProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
