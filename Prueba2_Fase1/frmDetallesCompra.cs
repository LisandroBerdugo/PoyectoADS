using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Prueba2_Fase1.DAL;
using Prueba2_Fase1.EL;

namespace Prueba2_Fase1
{
    public partial class frmDetallesCompra : Form
    {
        private int compraID;

        public frmDetallesCompra(int compraID)
        {
            InitializeComponent();
            this.compraID = compraID;
            CargarDetallesCompra();
        }

        private void CargarDetallesCompra()
        {
            ComprasDAL comprasDal = new ComprasDAL();
            ComprasEL compra = comprasDal.ObtenerCompraPorID(compraID);
            MostrarDetalles(compra);
        }

        private void MostrarDetalles(ComprasEL compra)
        {
            dgvDetalles.Columns.Clear();
            dgvDetalles.AutoGenerateColumns = false;
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.ReadOnly = true;

            dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Producto", DataPropertyName = "ItemNombre", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Cantidad", DataPropertyName = "Cantidad", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Precio Compra", DataPropertyName = "PrecioCompra", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Proveedor", DataPropertyName = "ProveedorNombre", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Teléfono Proveedor", DataPropertyName = "ProveedorTelefono", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });

            var dataSource = new List<dynamic>();
            foreach (var detalle in compra.Detalles)
            {
                dataSource.Add(new
                {
                    ItemNombre = detalle.ItemNombre,
                    Cantidad = detalle.Cantidad,
                    PrecioCompra = detalle.PrecioCompra,
                    ProveedorNombre = compra.ProveedorNombre,
                    ProveedorTelefono = compra.ProveedorTelefono
                });
            }
            dgvDetalles.DataSource = dataSource;
        }
    }
}
