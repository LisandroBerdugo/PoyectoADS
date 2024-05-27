using Prueba2_Fase1.Entities;
using Prueba2_Fase1.DAL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Prueba2_Fase1
{
    public partial class frmEditarUsu : Form
    {
        private UsuariosDAL usuariosDAL;
        private int usuarioID;

        public frmEditarUsu(int id)
        {
            InitializeComponent();
            usuariosDAL = new UsuariosDAL();
            usuarioID = id;
            CargarUsuario();
        }

        private void CargarUsuario()
        {
            try
            {
                Usuario usuario = usuariosDAL.ObtenerUsuarios().Find(u => u.ID == usuarioID);
                if (usuario != null)
                {
                    textBoxNombre.Text = usuario.Nombre;
                    textBoxEmail.Text = usuario.Email;
                    textBoxContraseña.Text = usuario.Contraseña;
                    checkBoxActivo.Checked = usuario.Activo;
                    comboBoxRol.SelectedValue = usuario.RolID;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuario: " + ex.Message);
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Usuario usuarioActualizado = new Usuario
            {
                ID = usuarioID,
                Nombre = textBoxNombre.Text,
                Email = textBoxEmail.Text,
                Contraseña = textBoxContraseña.Text,
                Activo = checkBoxActivo.Checked,
                FechaRegistro = DateTime.Now,
                RolID = Convert.ToInt32(comboBoxRol.SelectedValue)
            };

            try
            {
                usuariosDAL.ActualizarUsuario(usuarioActualizado);
                MessageBox.Show("Usuario actualizado correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar usuario: " + ex.Message);
            }
        }

        private void frmEditarUsu_Load(object sender, EventArgs e)
        {
            // Aquí puedes cargar los roles en el comboBoxRol
            try
            {
                List<Rol> roles = usuariosDAL.ObtenerRoles();
                comboBoxRol.DataSource = roles;
                comboBoxRol.DisplayMember = "Nombre";
                comboBoxRol.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar roles: " + ex.Message);
            }
        }
    }
}
