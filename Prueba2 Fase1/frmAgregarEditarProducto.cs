using System;
using System.Windows.Forms;
using Prueba2_Fase1.DAL;
using Prueba2_Fase1.EL;

namespace Prueba2_Fase1
{
    public partial class frmAgregarEditarProducto : Form
    {
        private ProductosDAL productosDAL;
        private ProductosEL producto;

        public frmAgregarEditarProducto(ProductosEL producto)
        {
            InitializeComponent();
            productosDAL = new ProductosDAL();
            this.producto = producto;

            if (producto != null)
            {
                txtNombre.Text = producto.Nombre;
                txtDescripcion.Text = producto.Descripcion;
                numPrecio.Value = producto.Precio;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (producto == null)
            {
                producto = new ProductosEL();
            }

            producto.Nombre = txtNombre.Text;
            producto.Descripcion = txtDescripcion.Text;
            producto.Precio = numPrecio.Value;

            if (producto.ID == 0)
            {
                productosDAL.AgregarProducto(producto);
            }
            else
            {
                productosDAL.EditarProducto(producto);
            }

            DialogResult = DialogResult.OK;
        }
    }
}
