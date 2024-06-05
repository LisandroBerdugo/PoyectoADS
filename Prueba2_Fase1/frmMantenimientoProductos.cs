using Prueba2_Fase1.DAL;
using Prueba2_Fase1.EL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Prueba2_Fase1
{
    public partial class frmMantenimientoProductos : Form
    {
        private ProductosDAL productosDAL;

        public frmMantenimientoProductos()
        {
            InitializeComponent();
            productosDAL = new ProductosDAL();
        }

        private void frmMantenimientoProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            List<ProductosEL> productos = productosDAL.ObtenerTodosLosProductos();
            var productosConMateriasPrimas = productos.SelectMany(p => p.MateriaPrimaNecesaria.Select(mp => new
            {
                p.ID,
                p.Nombre,
                p.Descripcion,
                p.Precio,
                MateriaPrima = mp.MateriaPrimaNombre,
                mp.Cantidad
            })).ToList();

            dgvProductos.DataSource = productosConMateriasPrimas;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarEditarProducto frmAgregar = new frmAgregarEditarProducto(null);
            frmAgregar.ProductoGuardado += (s, ev) => CargarProductos();
            frmAgregar.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                int productoID = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["ID"].Value);
                ProductosEL producto = productosDAL.ObtenerProductoPorID(productoID);

                frmAgregarEditarProducto frmEditar = new frmAgregarEditarProducto(producto);
                frmEditar.ProductoGuardado += (s, ev) => CargarProductos();
                frmEditar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un producto para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
