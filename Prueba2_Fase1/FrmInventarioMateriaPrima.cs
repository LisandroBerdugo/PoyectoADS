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

            // Configurar DataGridView manualmente para excluir ProductoID
            dgvInventarioMateriaPrima.Columns.Clear();
            dgvInventarioMateriaPrima.AutoGenerateColumns = false;

            dgvInventarioMateriaPrima.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "MateriaPrimaID",
                DataPropertyName = "MateriaPrimaID",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvInventarioMateriaPrima.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvInventarioMateriaPrima.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Cantidad",
                DataPropertyName = "Cantidad",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvInventarioMateriaPrima.DataSource = inventario;
        }
    }
}
