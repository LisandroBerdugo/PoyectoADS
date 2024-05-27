using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Prueba2_Fase1.DAL;
using Prueba2_Fase1.EL;

namespace Prueba2_Fase1
{
    public partial class FrmPrueba5 : Form
    {
        private InventarioDAL inventarioDal;

        public FrmPrueba5()
        {
            InitializeComponent();
            inventarioDal = new InventarioDAL();
        }

        private void FrmPrueba5_Load(object sender, EventArgs e)
        {
            CargarInventario();
        }

        private void CargarInventario()
        {
            List<InventarioEL> inventario = inventarioDal.ObtenerInventario();
            dgvInventario.DataSource = inventario;
        }
    }
}
