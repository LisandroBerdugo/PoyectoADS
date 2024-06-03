using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
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

           // numCantidad.Minimum = 1;
          //  numCantidad.Value = 1;
          //  numCantidad.Validating += new System.ComponentModel.CancelEventHandler(NumCantidad_Validating);

            numPrecioCompra.Minimum = 0.01M;
            numPrecioCompra.Value = 0.01M;
            numPrecioCompra.Validating += new System.ComponentModel.CancelEventHandler(NumPrecioCompra_Validating);
        }

        private void NumCantidad_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            /*
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
            }*/
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
            Producto = (ProductosEL)cbProductos.SelectedItem;
            Cantidad = Convert.ToInt32(txtCantidad.Text);
            PrecioCompra = numPrecioCompra.Value;
            DialogResult = DialogResult.OK;
            Close();
        }



        private void txtCantidad_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Variables de control
            Regex numberchk = new Regex(@"^(?:-?(?:0|[1-9]\d{0,9})|(?:-2147483648))$");
            bool valido = true;
            int valor = 0;

            // Valida que sea un numero
            if (!numberchk.IsMatch(txtCantidad.Text))
            {
                errorProvider.SetError(txtCantidad, "Debe digitar un valor numerico entero");
                valido = false;
            }
            else {
                valor = Convert.ToInt32(txtCantidad.Text.Trim());
            }

            // Validamos longitudes
            if (valido)
                if (valor <= 0 || valor > 1000)
                {
                    valido = false;
                    errorProvider.SetError(txtCantidad, "Debe ingresar un numero entre 1 y 1000");
                }

            // Evalua la validacion final
            if(valido)
                errorProvider.Clear();
            else
                e.Cancel = true;
        }
    }
}
