using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Prueba2_Fase1.DAL;
using Prueba2_Fase1.EL;
using MySqlConnector;

namespace Prueba2_Fase1
{
    public partial class frmCrearJuguete : Form
    {
        private ProductosDAL productosDAL;
        private MateriaPrimaDAL materiaPrimaDAL;
        private Conexion conexion;

        public frmCrearJuguete()
        {
            InitializeComponent();
            productosDAL = new ProductosDAL();
            materiaPrimaDAL = new MateriaPrimaDAL();
            conexion = new Conexion();
        }

        private void frmCrearJuguete_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            var productos = productosDAL.ObtenerTodosLosProductos();
            cbProducto.DataSource = productos;
            cbProducto.DisplayMember = "Nombre";
            cbProducto.ValueMember = "ID";
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            var productoSeleccionado = (ProductosEL)cbProducto.SelectedItem;
            var cantidad = (int)numCantidad.Value;

            if (!ValidarMateriaPrima(productoSeleccionado, cantidad))
            {
                MessageBox.Show("No hay suficiente materia prima para crear este juguete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ActualizarInventarioYCrearProducto(productoSeleccionado, cantidad);
            MessageBox.Show("Juguete creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private bool ValidarMateriaPrima(ProductosEL producto, int cantidad)
        {
            foreach (var materiaPrimaNecesaria in producto.MateriaPrimaNecesaria)
            {
                int cantidadDisponible = materiaPrimaDAL.ObtenerCantidadMateriaPrima(materiaPrimaNecesaria.MateriaPrimaID);
                if (cantidadDisponible < (materiaPrimaNecesaria.Cantidad * cantidad))
                {
                    return false;
                }
            }
            return true;
        }

        private void ActualizarInventarioYCrearProducto(ProductosEL producto, int cantidad)
        {
            using (MySqlConnection con = conexion.Conectar())
            {
                con.Open();

                // Descontar la materia prima utilizada
                foreach (var materiaPrimaNecesaria in producto.MateriaPrimaNecesaria)
                {
                    int cantidadUsada = materiaPrimaNecesaria.Cantidad * cantidad;

                    // Actualizamos el movimiento para que reste la materia prima
                    MySqlCommand cmdDescontar = new MySqlCommand(
                        "INSERT INTO Almacenamiento (MateriaPrimaID, Cantidad, TipoMovimiento) VALUES (@MateriaPrimaID, @Cantidad, 'USO')",
                        con);
                    cmdDescontar.Parameters.AddWithValue("@MateriaPrimaID", materiaPrimaNecesaria.MateriaPrimaID);
                    cmdDescontar.Parameters.AddWithValue("@Cantidad", -cantidadUsada); // Restar la cantidad usada
                    cmdDescontar.ExecuteNonQuery();
                }

                // Añadir el producto creado al inventario (opcional, dependiendo de tu lógica)
                MySqlCommand cmdCrearProducto = new MySqlCommand(
                    "INSERT INTO Almacenamiento (ProductoID, Cantidad, TipoMovimiento) VALUES (@ProductoID, @Cantidad, 'COMPRA')",
                    con);
                cmdCrearProducto.Parameters.AddWithValue("@ProductoID", producto.ID);
                cmdCrearProducto.Parameters.AddWithValue("@Cantidad", cantidad);
                cmdCrearProducto.ExecuteNonQuery();

                con.Close();
            }
        }
    }
}
