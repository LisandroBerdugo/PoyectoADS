using Prueba2_Fase1.DAL;
using Prueba2_Fase1.EL;
using System;
using System.Windows.Forms;

namespace Prueba2_Fase1
{
    public partial class frmEditarCliente : Form
    {
        private ClientesDAL clientesDAL;
        private int clienteID;

        public frmEditarCliente(int id)
        {
            InitializeComponent();
            clientesDAL = new ClientesDAL();
            clienteID = id;
            CargarDatosCliente();
        }

        private void CargarDatosCliente()
        {
            ClientesEL cliente = clientesDAL.ObtenerClientePorID(clienteID);

            if (cliente != null)
            {
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtEmail.Text = cliente.Email;
                txtTelefono.Text = cliente.Telefono;
                txtDireccion.Text = cliente.Direccion;
            }
            else
            {
                MessageBox.Show("No se pudo cargar la información del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
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
                ID = clienteID,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Email = txtEmail.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text
            };

            clientesDAL.ActualizarCliente(cliente);
            MessageBox.Show("Cliente actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
