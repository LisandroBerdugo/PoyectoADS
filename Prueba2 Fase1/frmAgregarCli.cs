using Prueba2_Fase1.DAL;
using Prueba2_Fase1.EL;
using System;
using System.Windows.Forms;

namespace Prueba2_Fase1
{
    public partial class frmAgregarCliente : Form
    {
        private ClientesDAL clientesDAL;

        public frmAgregarCliente()
        {
            InitializeComponent();
            clientesDAL = new ClientesDAL();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Debe ingresar nombre y apellido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClientesEL cliente = new ClientesEL
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Email = txtEmail.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text,
                FechaRegistro = DateTime.Now
            };

            clientesDAL.AgregarCliente(cliente);
            MessageBox.Show("Cliente agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
