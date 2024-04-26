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
    public partial class frmDetVentas : Form
    {
        public frmDetVentas()
        {
            InitializeComponent();

            this.MaximizeBox = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            frmSeleccionarProducto formSeleccionarProducto = new frmSeleccionarProducto();
            formSeleccionarProducto.ShowDialog();
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            frmSeleccionarCliente formSeleccionarCliente = new frmSeleccionarCliente();
            formSeleccionarCliente.ShowDialog();
        }

        private void frmDetVentas_Load(object sender, EventArgs e)
        {

        }
    }
}
