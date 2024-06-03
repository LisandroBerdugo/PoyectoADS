using Prueba2_Fase1.Entities;
using Prueba2_Fase1.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Prueba2_Fase1
{
    public partial class FrmUsuarios : Form
    {
        private UsuariosDAL usuariosDAL;

        public FrmUsuarios()
        {
            InitializeComponent();
            usuariosDAL = new UsuariosDAL();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarRoles();
            CargarEstados();
        }

        private void CargarUsuarios(string filtroNombre = "", string rol = "Todos", string estado = "Todos")
        {
            try
            {
                List<Usuario> usuarios = usuariosDAL.ObtenerUsuarios();

                if (!string.IsNullOrEmpty(filtroNombre))
                {
                    usuarios = usuarios.Where(u => u.Nombre.Contains(filtroNombre, StringComparison.OrdinalIgnoreCase)).ToList();
                }

                if (rol != "Todos")
                {
                    int rolID = Convert.ToInt32(comboBoxRol.SelectedValue);
                    usuarios = usuarios.Where(u => u.RolID == rolID).ToList();
                }

                if (estado != "Todos")
                {
                    bool isActive = estado == "Activo";
                    usuarios = usuarios.Where(u => u.Activo == isActive).ToList();
                }

                DataTable dt = ConvertToDataTable(usuarios);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["ID"].Visible = false; // Ocultar la columna de ID para que no se vea, pero esté accesible
                AjustarColumnas(); // Ajustar el ancho de las columnas
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }
        }

        private void CargarRoles()
        {
            try
            {
                List<Rol> roles = usuariosDAL.ObtenerRoles();
                roles.Insert(0, new Rol { ID = 0, Nombre = "Todos" }); // Insertar "Todos" como opción predeterminada
                comboBoxRol.DataSource = roles;
                comboBoxRol.DisplayMember = "Nombre";
                comboBoxRol.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar roles: " + ex.Message);
            }
        }

        private void CargarEstados()
        {
            comboBoxEstado.Items.Add("Todos");
            comboBoxEstado.Items.Add("Activo");
            comboBoxEstado.Items.Add("Inactivo");
            comboBoxEstado.SelectedIndex = 0; // Seleccionar "Todos" por defecto
        }

        private DataTable ConvertToDataTable(List<Usuario> usuarios)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Activo", typeof(bool));
            dt.Columns.Add("FechaRegistro", typeof(DateTime));
            dt.Columns.Add("Rol", typeof(string)); // Cambiado de RolID a Rol

            foreach (var usuario in usuarios)
            {
                dt.Rows.Add(usuario.ID, usuario.Nombre, usuario.Email, usuario.Activo, usuario.FechaRegistro, usuario.RolNombre);
            }

            return dt;
        }

        private void AjustarColumnas()
        {
            dataGridView1.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Activo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["FechaRegistro"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Rol"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Asegurarse de ajustar el ancho de la columna Rol
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtroNombre = textBoxFiltroNombre.Text.Trim();
            string rol = comboBoxRol.Text; // Usar el texto en lugar del valor seleccionado
            string estado = comboBoxEstado.Text; // Usar el texto en lugar del valor seleccionado
            CargarUsuarios(filtroNombre, rol, estado);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarUsu formAgregarUsuario = new frmAgregarUsu();
            formAgregarUsuario.ShowDialog();
            CargarUsuarios();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int usuarioID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                frmEditarUsu formEditarUsuario = new frmEditarUsu(usuarioID);
                formEditarUsuario.ShowDialog();
                CargarUsuarios();
            }
            else
            {
                Mensajes.Advertencia("Seleccione un usuario para editar.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Este evento puede ser utilizado para manejar clics en celdas específicas si es necesario
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
