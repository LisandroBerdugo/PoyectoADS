using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Prueba2_Fase1.DAL;
using Prueba2_Fase1.EL;

namespace Prueba2_Fase1
{
    public partial class frmPrueba3 : Form
    {
        private VentasDAL ventasDal;
        private ClientesDAL clientesDal;
        private ProductosDAL productosDal;
        private List<DetalleVentaEL> detallesVenta;

        public frmPrueba3()
        {
            InitializeComponent();
            ventasDal = new VentasDAL();
            clientesDal = new ClientesDAL();
            productosDal = new ProductosDAL();
            detallesVenta = new List<DetalleVentaEL>();
        }

        private void FrmPrueba3_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarProductos();
        }

        private void CargarClientes()
        {
            List<ClientesEL> clientes = clientesDal.ObtenerClientes();
            cbClientes.DataSource = clientes;
            cbClientes.DisplayMember = "Nombre";
            cbClientes.ValueMember = "ID";
        }

        private void CargarProductos()
        {
            List<ProductosEL> productos = productosDal.ObtenerTodosLosProductos();
            cbProductos.DataSource = productos;
            cbProductos.DisplayMember = "Nombre";
            cbProductos.ValueMember = "ID";
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (cbProductos.SelectedItem == null || numCantidad.Value <= 0 || numPrecioVenta.Value <= 0)
            {
                MessageBox.Show("Debe seleccionar un producto, una cantidad válida y un precio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProductosEL producto = (ProductosEL)cbProductos.SelectedItem;
            DetalleVentaEL detalle = new DetalleVentaEL
            {
                ProductoID = producto.ID,
                ProductoNombre = producto.Nombre,
                Cantidad = (int)numCantidad.Value,
                PrecioVenta = numPrecioVenta.Value
            };
            detallesVenta.Add(detalle);
            MostrarDetallesVenta();
        }

        private void MostrarDetallesVenta()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = detallesVenta;
        }

        private void BtnFinalizarVenta_Click(object sender, EventArgs e)
        {
            if (cbClientes.SelectedItem == null || detallesVenta.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente y agregar al menos un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            VentasEL venta = new VentasEL
            {
                ClienteID = ((ClientesEL)cbClientes.SelectedItem).ID,
                UsuarioID = 1, // Aquí puedes asignar el ID del usuario actual
                FechaVenta = DateTime.Now,
                Detalles = detallesVenta
            };

            ventasDal.InsertarVenta(venta);
            MessageBox.Show("Venta realizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
