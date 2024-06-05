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

            // Configurar DataGridView manualmente para excluir MateriaPrimaID
            dgvInventario.Columns.Clear();
            dgvInventario.AutoGenerateColumns = false;

            dgvInventario.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ProductoID",
                DataPropertyName = "ProductoID",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvInventario.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvInventario.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Cantidad",
                DataPropertyName = "Cantidad",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvInventario.DataSource = inventario;
        }

        private void btnMantenimientoProductos_Click(object sender, EventArgs e)
        {
            using (var frm = new frmMantenimientoProductos())
            {
                frm.ShowDialog();
                CargarInventario(); // Refrescar inventario después de cerrar el formulario
            }
        }

        private void btnVerInventarioMateriaPrima_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmInventarioMateriaPrima())
            {
                frm.ShowDialog();
                CargarInventario(); // Refrescar inventario después de cerrar el formulario
            }
        }

        private void btnCrearJuguete_Click(object sender, EventArgs e)
        {
            using (var frm = new frmCrearJuguete())
            {
                frm.ShowDialog();
                CargarInventario(); // Refrescar inventario después de cerrar el formulario
            }
        }
    }
}
