using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Prueba2_Fase1.DAL;
using Prueba2_Fase1.EL;

namespace Prueba2_Fase1
{
    public partial class frmMantenimientoProductos : Form
    {
        private ProductosDAL productosDAL;

        public frmMantenimientoProductos()
        {
            InitializeComponent();
            productosDAL = new ProductosDAL();
            CargarProductos();
        }

        private void CargarProductos(string nombreFiltro = "")
        {
            List<ProductosEL> productos;

            if (string.IsNullOrEmpty(nombreFiltro))
            {
                productos = productosDAL.ObtenerTodosLosProductos();
            }
            else
            {
                productos = productosDAL.BuscarProductosPorNombre(nombreFiltro);
            }

            dataGridViewProductos.DataSource = productos;
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarProductos(textBoxBuscar.Text);
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            frmAgregarEditarProducto frm = new frmAgregarEditarProducto(null);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarProductos();
            }
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.SelectedRows.Count > 0)
            {
                int idProducto = Convert.ToInt32(dataGridViewProductos.SelectedRows[0].Cells["ID"].Value);
                ProductosEL producto = productosDAL.ObtenerProductoPorID(idProducto);
                frmAgregarEditarProducto frm = new frmAgregarEditarProducto(producto);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarProductos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
