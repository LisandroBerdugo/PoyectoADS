using Prueba2_Fase1.DAL;
using Prueba2_Fase1.EL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Prueba2_Fase1
{
    public partial class FrmClientes : Form
    {
        private ClientesDAL clientesDAL;

        public FrmClientes()
        {
            InitializeComponent();
            clientesDAL = new ClientesDAL();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes(string filtroNombre = "")
        {
            try
            {
                List<ClientesEL> clientes = clientesDAL.ObtenerClientes();

                if (!string.IsNullOrEmpty(filtroNombre))
                {
                    clientes = clientes.Where(c => c.Nombre.Contains(filtroNombre, StringComparison.OrdinalIgnoreCase)).ToList();
                }

                DataTable dt = ConvertToDataTable(clientes);
                dataGridViewClientes.DataSource = dt;
                dataGridViewClientes.Columns["ID"].Visible = false; // Ocultar la columna de ID para que no se vea, pero esté accesible
                AjustarColumnas(); // Ajustar el ancho de las columnas
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }

        private DataTable ConvertToDataTable(List<ClientesEL> clientes)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Apellido", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Telefono", typeof(string));
            dt.Columns.Add("Direccion", typeof(string));
            dt.Columns.Add("FechaRegistro", typeof(DateTime));

            foreach (var cliente in clientes)
            {
                dt.Rows.Add(cliente.ID, cliente.Nombre, cliente.Apellido, cliente.Email, cliente.Telefono, cliente.Direccion, cliente.FechaRegistro);
            }

            return dt;
        }

        private void AjustarColumnas()
        {
            dataGridViewClientes.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewClientes.Columns["Apellido"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewClientes.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewClientes.Columns["Telefono"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewClientes.Columns["Direccion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewClientes.Columns["FechaRegistro"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtroNombre = textBoxFiltroNombre.Text.Trim();
            CargarClientes(filtroNombre);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarCliente formAgregarCliente = new frmAgregarCliente();
            formAgregarCliente.ShowDialog();
            CargarClientes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count > 0)
            {
                int clienteID = Convert.ToInt32(dataGridViewClientes.SelectedRows[0].Cells["ID"].Value);
                frmEditarCliente formEditarCliente = new frmEditarCliente(clienteID);
                formEditarCliente.ShowDialog();
                CargarClientes();
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridViewClientes.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
