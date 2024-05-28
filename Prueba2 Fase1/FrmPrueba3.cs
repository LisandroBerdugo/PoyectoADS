using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
        private InventarioDAL inventarioDal;
        private List<DetalleVentaEL> detallesVenta;

        public frmPrueba3()
        {
            InitializeComponent();
            ventasDal = new VentasDAL();
            clientesDal = new ClientesDAL();
            productosDal = new ProductosDAL();
            inventarioDal = new InventarioDAL();
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

        private void CbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProductos.SelectedItem != null)
            {
                ProductosEL producto = (ProductosEL)cbProductos.SelectedItem;
                txtPrecioVenta.Text = producto.Precio.ToString("F2");
            }
        }

        private void NumCantidad_Validating(object sender, CancelEventArgs e)
        {
            if (numCantidad.Value < 1)
            {
                e.Cancel = true;
                MessageBox.Show("La cantidad debe ser al menos 1.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numCantidad.Value = 1; // Restablecer el valor a 1
            }
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (cbProductos.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numCantidad.Value < 1)
            {
                MessageBox.Show("La cantidad debe ser al menos 1.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numCantidad.Value = 1; // Restablecer el valor a 1
                return;
            }

            ProductosEL producto = (ProductosEL)cbProductos.SelectedItem;

            // Verificar si el producto ya ha sido agregado
            if (detallesVenta.Any(d => d.ProductoID == producto.ID))
            {
                MessageBox.Show("Este producto ya ha sido agregado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar stock disponible
            InventarioEL inventario = inventarioDal.ObtenerInventarioPorProductoID(producto.ID);
            if (inventario == null || inventario.Cantidad < (int)numCantidad.Value)
            {
                MessageBox.Show("No hay suficiente stock para la venta que se quiere realizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DetalleVentaEL detalle = new DetalleVentaEL
            {
                ProductoID = producto.ID,
                ProductoNombre = producto.Nombre,
                Cantidad = (int)numCantidad.Value,
                PrecioVenta = producto.Precio
            };
            detallesVenta.Add(detalle);
            MostrarDetallesVenta();
        }

        private void MostrarDetallesVenta()
        {
            dgvProductos.DataSource = null;
            dgvProductos.Columns.Clear();

            var dataSource = detallesVenta.Select(d => new
            {
                d.ProductoNombre,
                Cantidad = d.Cantidad,
                PrecioUnitario = d.PrecioVenta,
                Total = d.Cantidad * d.PrecioVenta
            }).ToList();

            dgvProductos.DataSource = dataSource;

            dgvProductos.Columns["ProductoNombre"].HeaderText = "Producto";
            dgvProductos.Columns["Cantidad"].HeaderText = "Cantidad";
            dgvProductos.Columns["PrecioUnitario"].HeaderText = "Precio Unitario";
            dgvProductos.Columns["Total"].HeaderText = "Total";
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

            // Limpiar los campos para una nueva venta
            detallesVenta.Clear();
            MostrarDetallesVenta();
            cbClientes.SelectedIndex = -1;
            cbProductos.SelectedIndex = -1;
            numCantidad.Value = 1;
            txtPrecioVenta.Clear();
        }
    }
}
