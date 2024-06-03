using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Prueba2_Fase1.EL;
using Prueba2_Fase1.DAL;

namespace Prueba2_Fase1
{
    public partial class FrmPrueba2 : Form
    {
        private ComprasDAL comprasDal = new ComprasDAL();

        public FrmPrueba2()
        {
            InitializeComponent();
        }

        private void FrmPrueba2_Load(object sender, EventArgs e)
        {
            CargarCompras();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = new DateTime(dtpFechaInicio.Value.Year,
                dtpFechaInicio.Value.Month,
                dtpFechaInicio.Value.Day,
                0, 0, 0);
            DateTime fechaFin = new DateTime(dtpFechaFin.Value.Year,
                dtpFechaFin.Value.Month,
                dtpFechaFin.Value.Day,
                23, 59, 59);
            string filtro = txtFiltro.Text;
            List<ComprasEL> compras = comprasDal.ObtenerComprasFiltradas(fechaInicio, fechaFin, filtro);
            MostrarCompras(compras);
        }

        private void BtnAbrirFrmCompras_Click(object sender, EventArgs e)
        {
            using (frmCompras formCompras = new frmCompras())
            {
                if (formCompras.ShowDialog() == DialogResult.OK)
                {
                    CargarCompras();
                }
            }
        }

        private void BtnVerDetalles_Click(object sender, EventArgs e)
        {
            if (dgvCompras.SelectedRows.Count > 0)
            {
                int compraID = (int)dgvCompras.SelectedRows[0].Cells["CompraID"].Value;
                using (var frmDetalles = new frmDetallesCompra(compraID))
                {
                    frmDetalles.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una compra para ver los detalles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvCompras_SelectionChanged(object sender, EventArgs e)
        {
            btnVerDetalles.Enabled = dgvCompras.SelectedRows.Count > 0;
        }

        private void CargarCompras()
        {
            List<ComprasEL> compras = comprasDal.ObtenerCompras();
            MostrarCompras(compras);
        }

        private void MostrarCompras(List<ComprasEL> compras)
        {
            dgvCompras.DataSource = null;
            var dataSource = new List<dynamic>();
            foreach (var compra in compras)
            {
                foreach (var detalle in compra.Detalles)
                {
                    dataSource.Add(new
                    {
                        CompraID = compra.ID,
                        Producto = detalle.ProductoNombre,
                        Cantidad = detalle.Cantidad, 
                        ValorCompra = detalle.PrecioCompra,
                        FechaCompra = compra.FechaCompra
                    });
                }
            }

            dgvCompras.DataSource = dataSource;
            if (compras.Count > 0)
            {
                dgvCompras.Columns["CompraID"].DisplayIndex = 0;
                dgvCompras.Columns["Producto"].DisplayIndex = 1;
                dgvCompras.Columns["Cantidad"].DisplayIndex = 2;
                dgvCompras.Columns["ValorCompra"].DisplayIndex = 3;
                dgvCompras.Columns["FechaCompra"].DisplayIndex = 4;
            }
        }

    }
}
