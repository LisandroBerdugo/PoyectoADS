using Prueba2_Fase1.EL;
using Prueba2_Fase1.DAL;

namespace Prueba2_Fase1
{
    public partial class frmRegistrarProducto : Form
    {
        private ProductosDAL productosDAL;

        public frmRegistrarProducto()
        {
            InitializeComponent();
            productosDAL = new ProductosDAL();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           /* ProductosEL producto = new ProductosEL
            {
                Nombre = textBoxNombre.Text,
                Descripcion = textBoxDescripcion.Text,
                Precio = decimal.Parse(textBoxPrecio.Text)
            };

            productosDAL.AgregarProducto(producto); */
        }
    }
}
