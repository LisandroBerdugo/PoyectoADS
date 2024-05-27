using Prueba2_Fase1.EL;
using Prueba2_Fase1.DAL;

namespace Prueba2_Fase1
{
    public partial class frmSeleccionarProducto : Form
    {
        public frmSeleccionarProducto()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Implementación para buscar productos
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Implementación para agregar productos seleccionados
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public List<ProductosEL> ObtenerProductosSeleccionados()
        {
            List<ProductosEL> productosSeleccionados = new List<ProductosEL>();
            // Implementación para obtener productos seleccionados del DataGridView
            return productosSeleccionados;
        }
    }
}
