using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Prueba2_Fase1.DAL;
using Prueba2_Fase1.EL;

namespace Prueba2_Fase1
{
    public partial class FrmPrueba2 : Form
    {
        private ComprasDAL comprasDal;

        public FrmPrueba2()
        {
            InitializeComponent();
            comprasDal = new ComprasDAL();
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
                int compraID = (int)dgvCompras.SelectedRows[0].Cells["ID"].Value;
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
            dgvCompras.Rows.Clear();
            dgvCompras.Columns.Clear();

            DataTable dt = ConvertToDataTable(compras);
            dgvCompras.DataSource = dt;

            AjustarColumnas();
        }

        private DataTable ConvertToDataTable(List<ComprasEL> compras)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Materia Prima", typeof(string));
            dt.Columns.Add("Cantidad", typeof(int));
            dt.Columns.Add("Precio", typeof(decimal));

            foreach (var compra in compras)
            {
                foreach (var detalle in compra.Detalles)
                {
                    if (detalle.TipoItem == "Materia Prima")
                    {
                        dt.Rows.Add(compra.ID, detalle.ItemNombre, detalle.Cantidad, detalle.PrecioCompra);
                    }
                }
            }

            return dt;
        }

        private void AjustarColumnas()
        {
            dgvCompras.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCompras.Columns["Materia Prima"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCompras.Columns["Cantidad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCompras.Columns["Precio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
