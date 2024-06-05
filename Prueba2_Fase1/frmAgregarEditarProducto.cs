using System;
using System.Windows.Forms;
using Prueba2_Fase1.DAL;
using Prueba2_Fase1.EL;
using System.Collections.Generic;

namespace Prueba2_Fase1
{
    public partial class frmAgregarEditarProducto : Form
    {
        private ProductosDAL productosDAL;
        private MateriaPrimaDAL materiaPrimaDAL;
        private ProductosEL producto;

        // Definir el evento
        public event EventHandler ProductoGuardado;

        public frmAgregarEditarProducto(ProductosEL producto)
        {
            InitializeComponent();
            productosDAL = new ProductosDAL();
            materiaPrimaDAL = new MateriaPrimaDAL();
            this.producto = producto;

            if (producto != null)
            {
                txtNombre.Text = producto.Nombre;
                txtDescripcion.Text = producto.Descripcion;
                numPrecio.Value = producto.Precio;
                CargarMateriaPrimaNecesaria();
            }
            else
            {
                this.producto = new ProductosEL();
                this.producto.MateriaPrimaNecesaria = new List<MateriaPrimaNecesariaEL>();
            }

            CargarMateriasPrimas();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo Nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numPrecio.Value < 0.01m)
            {
                MessageBox.Show("El precio debe ser mayor o igual a 0.01.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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

            // Disparar el evento
            OnProductoGuardado(EventArgs.Empty);

            DialogResult = DialogResult.OK;
        }

        // Método para disparar el evento
        protected virtual void OnProductoGuardado(EventArgs e)
        {
            ProductoGuardado?.Invoke(this, e);
        }

        private void btnAgregarMateriaPrima_Click(object sender, EventArgs e)
        {
            var materiaPrimaSeleccionada = (MateriaPrima)cbMateriaPrima.SelectedItem;
            if (materiaPrimaSeleccionada != null)
            {
                producto.MateriaPrimaNecesaria.Add(new MateriaPrimaNecesariaEL
                {
                    MateriaPrimaID = materiaPrimaSeleccionada.ID,
                    MateriaPrimaNombre = materiaPrimaSeleccionada.Nombre,
                    Cantidad = 1 // Aquí puedes poner una lógica para determinar la cantidad
                });

                CargarMateriaPrimaNecesaria();
            }
        }

        private void CargarMateriasPrimas()
        {
            var materiasPrimas = materiaPrimaDAL.ObtenerTodas();
            cbMateriaPrima.DataSource = materiasPrimas;
            cbMateriaPrima.DisplayMember = "Nombre";
            cbMateriaPrima.ValueMember = "ID";
        }

        private void CargarMateriaPrimaNecesaria()
        {
            dgvMateriaPrimaNecesaria.DataSource = null;
            dgvMateriaPrimaNecesaria.DataSource = producto.MateriaPrimaNecesaria;
            dgvMateriaPrimaNecesaria.Refresh();
        }
    }
}
