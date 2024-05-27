using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Prueba2_Fase1.EL;

namespace Prueba2_Fase1
{
    public partial class FormAgregarProducto : Form
    {
        public ProductosEL Producto { get; private set; }
        public int Cantidad { get; private set; }
        public decimal PrecioCompra { get; private set; }

        public FormAgregarProducto(List<ProductosEL> productos)
        {
            InitializeComponent();
            cbProductos.DataSource = productos;
            cbProductos.DisplayMember = "Nombre";
            cbProductos.ValueMember = "ID";
            cbProductos.DropDownStyle = ComboBoxStyle.DropDownList; // Evita que se puedan editar los items del ComboBox

            numCantidad.Minimum = 1;
            numCantidad.Value = 1;
            numCantidad.Validating += new System.ComponentModel.CancelEventHandler(NumCantidad_Validating);

            numPrecioCompra.Minimum = 0.01M;
            numPrecioCompra.Value = 0.01M;
            numPrecioCompra.Validating += new System.ComponentModel.CancelEventHandler(NumPrecioCompra_Validating);
        }

        private void NumCantidad_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (numCantidad.Value < 1)
            {
                e.Cancel = true;
                numCantidad.Focus();
                errorProvider.SetError(numCantidad, "La cantidad no puede ser menor a 1.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(numCantidad, null);
            }
        }

        private void NumPrecioCompra_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (numPrecioCompra.Value < 0.01M)
            {
                e.Cancel = true;
                numPrecioCompra.Focus();
                errorProvider.SetError(numPrecioCompra, "El precio debe ser mayor o igual a 0.01.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(numPrecioCompra, null);
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Debe ingresar valores válidos para cantidad y precio.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Producto = (ProductosEL)cbProductos.SelectedItem;
            Cantidad = (int)numCantidad.Value;
            PrecioCompra = numPrecioCompra.Value;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
