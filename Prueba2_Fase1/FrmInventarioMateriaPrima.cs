using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Prueba2_Fase1.DAL;
using Prueba2_Fase1.EL;

namespace Prueba2_Fase1
{
    public partial class FrmInventarioMateriaPrima : Form
    {
        private InventarioDAL inventarioDal;

        public FrmInventarioMateriaPrima()
        {
            InitializeComponent();
            inventarioDal = new InventarioDAL();
        }

        private void FrmInventarioMateriaPrima_Load(object sender, EventArgs e)
        {
            CargarInventario();
        }

        private void CargarInventario()
        {
            List<InventarioEL> inventario = inventarioDal.ObtenerInventarioMateriaPrima();
            dgvInventarioMateriaPrima.DataSource = inventario;
        }
    }
}
