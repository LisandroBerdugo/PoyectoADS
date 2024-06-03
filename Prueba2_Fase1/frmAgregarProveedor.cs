using System;
using System.Windows.Forms;
using Prueba2_Fase1.DAL;
using Prueba2_Fase1.EL;

namespace Prueba2_Fase1
{
    public partial class frmAgregarProveedor : Form
    {
        private ProveedoresDAL proveedoresDal;

        public frmAgregarProveedor()
        {
            InitializeComponent();
            proveedoresDal = new ProveedoresDAL();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProveedoresEL proveedor = new ProveedoresEL
            {
                Nombre = txtNombre.Text,
                Telefono = txtTelefono.Text
            };

            proveedoresDal.AgregarProveedor(proveedor);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
