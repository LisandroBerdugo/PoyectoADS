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
    public partial class FrmPrueba5 : Form
    {
        public FrmPrueba5()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmRegistrarProducto formRegistrarProducto = new frmRegistrarProducto();
            formRegistrarProducto.ShowDialog();
        }
    }
}
