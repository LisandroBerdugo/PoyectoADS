using System;
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
    public partial class frmSeleccionarProducto : Form
    {
        public frmSeleccionarProducto()
        {
            InitializeComponent();

            this.MaximizeBox = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistarProd_Click(object sender, EventArgs e)
        {
            frmRegistrarProducto formRegistrarProducto = new frmRegistrarProducto();
            formRegistrarProducto.ShowDialog();
        }

        private void frmSeleccionarProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
