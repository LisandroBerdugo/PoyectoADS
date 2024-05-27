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
        }

        private void CargarProveedores()
        {
            List<ProveedoresEL> proveedores = proveedoresDal.ObtenerProveedores();
            cbProveedores.DataSource = proveedores;
            cbProveedores.DisplayMember = "Nombre";
            cbProveedores.ValueMember = "ID";
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            ProductosDAL productoDAL = new ProductosDAL();
            List<ProductosEL> productos = productoDAL.ObtenerTodosLosProductos();

            using (var form = new FormAgregarProducto(productos))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dgvProductos.Rows)
                    {
                        if (row.Cells["colID"].Value != null && (int)row.Cells["colID"].Value == form.Producto.ID)
                        {
                            MessageBox.Show("El producto ya ha sido agregado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    dgvProductos.Rows.Add(form.Producto.ID, form.Producto.Nombre, form.Cantidad, form.PrecioCompra);
                }
            }
        }

        private void BtnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                dgvProductos.Rows.RemoveAt(dgvProductos.SelectedRows[0].Index);
            }
        }

        private void BtnRealizarCompra_Click(object sender, EventArgs e)
        {
            if (cbProveedores.SelectedItem == null || dgvProductos.Rows.Count == 0)
            {
                MessageBox.Show("Seleccione un proveedor y agregue al menos un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ComprasEL compra = new ComprasEL
            {
                ProveedorID = (int)cbProveedores.SelectedValue,
                UsuarioID = 1, // Reemplazar con el ID del usuario actual
                Activo = true,
                Detalles = new List<DetalleCompraEL>()
            };

            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                compra.Detalles.Add(new DetalleCompraEL
                {
                    ProductoID = (int)row.Cells["colID"].Value,
                    Cantidad = (int)row.Cells["colCantidad"].Value,
                    PrecioCompra = (decimal)row.Cells["colPrecioCompra"].Value
                });
            }

            int compraID = comprasDal.InsertarCompra(compra);
            foreach (var detalle in compra.Detalles)
            {
                detalle.CompraID = compraID;
                comprasDal.InsertarDetalleCompra(detalle);
            }

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
