using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Prueba2_Fase1.DAL;
using Prueba2_Fase1.EL;

namespace Prueba2_Fase1
{
    public partial class frmCompras : Form
    {
        private ComprasDAL comprasDal;
        private ProveedoresDAL proveedoresDal;

        public frmCompras()
        {
            InitializeComponent();
            comprasDal = new ComprasDAL();
            proveedoresDal = new ProveedoresDAL();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            CargarProveedores();
            ConfigurarDataGridView();
        }

        private void CargarProveedores()
        {
            List<ProveedoresEL> proveedores = proveedoresDal.ObtenerProveedores();
            cbProveedores.DataSource = proveedores;
            cbProveedores.DisplayMember = "Nombre";
            cbProveedores.ValueMember = "ID";
        }

        private void ConfigurarDataGridView()
        {
            dgvItems.Columns.Clear();

            dgvItems.Columns.Add("colID", "ID");
            dgvItems.Columns.Add("colNombre", "Nombre");
            dgvItems.Columns.Add("colCantidad", "Cantidad");
            dgvItems.Columns.Add("colPrecioCompra", "Precio Compra");

            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.ReadOnly = true;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtnAgregarItem_Click(object sender, EventArgs e)
        {
            MateriaPrimaDAL materiaPrimaDAL = new MateriaPrimaDAL();
            List<MateriaPrima> materiasPrimas = materiaPrimaDAL.ObtenerTodas();

            using (var form = new FormAgregarMateriaPrima(materiasPrimas))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dgvItems.Rows)
                    {
                        if (row.Cells["colID"].Value != null && (int)row.Cells["colID"].Value == form.MateriaPrima.ID)
                        {
                            MessageBox.Show("La materia prima ya ha sido agregada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    dgvItems.Rows.Add(form.MateriaPrima.ID, form.MateriaPrima.Nombre, form.Cantidad, form.PrecioCompra);
                }
            }
        }

        private void BtnEliminarItem_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                dgvItems.Rows.RemoveAt(dgvItems.SelectedRows[0].Index);
            }
        }

        private void BtnRealizarCompra_Click(object sender, EventArgs e)
        {
            if (cbProveedores.SelectedItem == null || dgvItems.Rows.Count == 0)
            {
                MessageBox.Show("Seleccione un proveedor y agregue al menos una materia prima.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ComprasEL compra = new ComprasEL
            {
                ProveedorID = (int)cbProveedores.SelectedValue,
                UsuarioID = 1, // Reemplazar con el ID del usuario actual
                Activo = true,
                Detalles = new List<DetalleCompraEL>()
            };

            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                compra.Detalles.Add(new DetalleCompraEL
                {
                    ItemID = (int)row.Cells["colID"].Value,
                    Cantidad = (int)row.Cells["colCantidad"].Value,
                    PrecioCompra = (decimal)row.Cells["colPrecioCompra"].Value,
                    TipoItem = "Materia Prima"
                });
            }

            comprasDal.InsertarCompra(compra);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnAgregarProveedor_Click(object sender, EventArgs e)
        {
            using (var form = new frmAgregarProveedor())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    CargarProveedores();
                }
            }
        }
    }
}
